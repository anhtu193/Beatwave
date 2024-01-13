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

namespace Beatwave.UserControls
{
    public partial class LongMusicItem : UserControl
    {
        public SongInfo Song
        {
            get { return song; }
            set
            {
                song = value;
                UpdateUI();
            }
        }

        public SongInfo song;
        public BunifuPictureBox CoverImage { get { return coverImage; } }
        public Label Title { get { return lb_title; } }
        public BunifuPanel SelectedPanel { get { return selectingPanel; } }
        public Label Artist { get { return lb_artist; } }
        public Label Duration { get { return lb_duration; } }

        public event EventHandler<string> MusicItemSelected;

        public LongMusicItem()
        {
            InitializeComponent();
        }

        private void UpdateUI()
        {
            if (song != null)
            {
                if (song.Cover != null && song.Cover.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(song.Cover))
                    {
                        Image image = Image.FromStream(ms);
                        Size newSize = ScaleImageSize(image.Size, coverImage.Size);
                        image = ResizeImage(image, newSize.Width, newSize.Height);

                        CoverImage.Image = image;
                    }
                }
                string durationString = song.Duration.ToString(@"mm\:ss");
                Duration.Text = durationString;
                CoverImage.BorderRadius = 10;
                SelectedPanel.BorderRadius = 20;
                CoverImage.AutoSizeHeight = false;
                Title.Text = song.Title;
                Artist.Text = song.Artist;
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.DrawImage(image, new Rectangle(0, 0, width, height));
            }
            return resizedImage;
        }

        private Size ScaleImageSize(Size imageSize, Size targetSize)
        {
            Size result = new Size();

            double scaleFactorX = (double)targetSize.Width / imageSize.Width;
            double scaleFactorY = (double)targetSize.Height / imageSize.Height;
            double scaleFactor = Math.Min(scaleFactorX, scaleFactorY);

            result.Width = (int)(imageSize.Width * scaleFactor);
            result.Height = (int)(imageSize.Height * scaleFactor);

            return result;
        }
        private void MusicItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (song != null)
                {
                    MusicItemSelected?.Invoke(this, song.Path);
                }
            }
        }

        private void LongMusicItem_Load(object sender, EventArgs e)
        {
            coverImage.BorderRadius = 10;
            selectingPanel.BorderRadius = 20;
        }
    }
}
