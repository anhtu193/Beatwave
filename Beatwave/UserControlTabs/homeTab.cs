using Beatwave.UserControls;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beatwave.UserControlTabs
{
    public partial class homeTab : UserControl
    {
        List<SongInfo> songsInfo;
        public event EventHandler<string> MusicItemSelected;
        public event EventHandler<List<SongInfo>> PlaylistUpdated;
        bool isPlaying = false;
        private int rotationAngle = 0;
        private Timer rotationTimer;
        private Bitmap originalImage;
        private Bitmap rotatedImage;
        private int lastStoppedAngle = 0;

        public homeTab()
        {
            InitializeComponent();
            loadSongs();
            DisplayMusicItems();
            InitializePlayingSongItem();
        }

        public void UpdateUI(bool isPlaying, SongInfo songInfo)
        {          
            if (songInfo.Cover != null && songInfo.Cover.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(songInfo.Cover))
                {
                    Image image = Image.FromStream(ms);
                    playing_cover.Image = image;
                }
            }
            originalImage = new Bitmap(playing_cover.Image);
            isPlaying = true;
            if (isPlaying == true)
            {
                label3.Visible = true;
                playing_cover.BorderRadius = 110; // Đặt borderRadius để làm hình tròn
                rotationAngle = 0;
                rotationTimer.Start(); // Bắt đầu quay hình ảnh
            }
            playing_title.Text = songInfo.Title;
            string durationString = songInfo.Duration.ToString(@"mm\:ss");
            playing_artist_duration.Text = songInfo.Artist + " • " + durationString;          
        }

        protected virtual void OnPlaylistUpdated(List<SongInfo> songs)
        {
            PlaylistUpdated?.Invoke(this, songs);
        }


        private void InitializePlayingSongItem()
        {
            playing_cover.BorderRadius = 110;
            if (isPlaying == false) label3.Visible = false;
            rotationTimer = new Timer();
            rotationTimer.Interval = 30; // Thay đổi tốc độ quay ở đây
            rotationTimer.Tick += RotationTimer_Tick;    
        }

        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            rotationAngle += 1;
            RotateImage(rotationAngle);
            playing_cover.Image = (Image)rotatedImage.Clone();
        }

        public void UpdatePlayingState(bool newIsPlayingState)
        {
            isPlaying = newIsPlayingState;

            if (isPlaying == false)
            {
                label3.Visible = false;
                StopRotation();
            }
            else
            {
                label3.Visible = true;
                StartRotation();
            }
        }

        private void RotateImage(float angle)
        {
            // Tạo một bitmap mới để xoay ảnh
            rotatedImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.Clear(Color.Transparent); // Xóa ảnh để vẽ ảnh mới

                g.TranslateTransform(originalImage.Width / 2, originalImage.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-originalImage.Width / 2, -originalImage.Height / 2);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel);
            }
        }

        private void StartRotation()
        {
            rotationAngle = lastStoppedAngle;
            rotationTimer.Start();
        }

        private void StopRotation()
        {
            lastStoppedAngle = rotationAngle;
            rotationTimer.Stop();
        }

        private void DisplayMusicItems()
        {
            if (songsInfo != null && songsInfo.Count > 0)
            {
                foreach (var song in songsInfo)
                {
                    MusicItem musicItem = new MusicItem();
                    musicItem.Song = song;
                    musicItem.Width = 195; // Đặt chiều rộng của MusicItem tại đây (tuỳ chỉnh cho phù hợp)
                    musicItem.Margin = new Padding(0); // Đặt margin để tạo khoảng trống giữa các MusicItem
                    musicItem.CoverImage.BorderRadius = 20;
                
                    musicItem.MusicItemSelected += MusicItem_MusicItemSelected; // Đăng ký sự kiện
                    // Thêm MusicItem vào FlowLayoutPanel
                    flowLayoutPanel.Controls.Add(musicItem);
                }
                
            }

        }

        private void MusicItem_MusicItemSelected(object sender, string songPath)
        {
            
            OnMusicItemSelected(sender, songPath);         
        }

        protected virtual void OnMusicItemSelected(object sender, string songPath)
        {
            MusicItemSelected?.Invoke(sender, songPath);
            SongInfo songPlaying;
            Mp3Reader mp3Reader = new Mp3Reader();
            songPlaying = mp3Reader.GetSongInfo(songPath);
            if (songPlaying.Cover != null && songPlaying.Cover.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(songPlaying.Cover))
                {
                    Image image = Image.FromStream(ms);                  
                    playing_cover.Image = image;
                }
            }
            originalImage = new Bitmap(playing_cover.Image);
            playing_title.Text = songPlaying.Title;
            string durationString = songPlaying.Duration.ToString(@"mm\:ss");
            playing_artist_duration.Text = songPlaying.Artist + " • " + durationString;
            isPlaying = true;
            if (isPlaying == true)
            {
                label3.Visible = true;
                playing_cover.BorderRadius = 110; // Đặt borderRadius để làm hình tròn
                rotationAngle = 0;
                rotationTimer.Start(); // Bắt đầu quay hình ảnh
            }
        }

        private void home_panel_Paint(object sender, PaintEventArgs e)
        {
            Color color1 = Color.FromArgb(74, 74, 74);
            Color color2 = Color.FromArgb(0, 0, 0);

            LinearGradientBrush brush = new LinearGradientBrush(
                home_panel.ClientRectangle,
                color1,
                color2,
                LinearGradientMode.Vertical); 

            e.Graphics.FillRectangle(brush, home_panel.ClientRectangle);

            brush.Dispose();
        }

        private void loadSongs()
        {
            string folderPath = @"E:\testMusic";
            Mp3Reader mp3Reader = new Mp3Reader();
            songsInfo = mp3Reader.GetSongsInfo(folderPath);

        }

        private void homeTab_Load(object sender, EventArgs e)
        {
            OnPlaylistUpdated(songsInfo);
        }
    }
}
