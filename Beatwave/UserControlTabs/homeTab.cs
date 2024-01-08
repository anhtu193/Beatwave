using Beatwave.UserControls;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public homeTab()
        {
            InitializeComponent();
            loadSongs();
            DisplayMusicItems();
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
        }

        private void home_panel_Paint(object sender, PaintEventArgs e)
        {
            Color color1 = Color.FromArgb(18, 18, 18);
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
    }
}
