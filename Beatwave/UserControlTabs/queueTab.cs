using Beatwave.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beatwave.UserControlTabs
{
    public partial class queueTab : UserControl
    {
        List<SongInfo> playlist;
        public event EventHandler<string> MusicItemSelected;
        private LongMusicItem currentPlayingItem;

        public queueTab()
        {
            InitializeComponent();
            playlist = new List<SongInfo>();
        }
        public void SetPlaylist(List<SongInfo> receivedPlaylist)
        {
            playlist = receivedPlaylist;
        }

        public void ResetSongList()
        {
            flowLayoutPanel.Controls.Clear();
        }
        public void SetCurrentPlayingItem(string songPath)
        {
            if (currentPlayingItem != null)
            {
                currentPlayingItem.SelectedPanel.BackColor = Color.Transparent;
            }

            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is LongMusicItem musicItem && musicItem.Song.Path == songPath)
                {
                    currentPlayingItem = musicItem;
                    currentPlayingItem.SelectedPanel.BackColor = Color.DimGray;
                    currentPlayingItem.SelectedPanel.BorderRadius = 20;
                    break;
                }
            }
        }
        public void DisplayMusicItems()
        {
            if (playlist != null && playlist.Count > 0)
            {
                foreach (var song in playlist)
                {
                    LongMusicItem musicItem = new LongMusicItem();
                    musicItem.Song = song;
                    musicItem.CoverImage.BorderRadius = 10;
                    musicItem.MouseHover += (sender, e) => LongMusicItem_MouseHover(sender, e, song);
                    musicItem.MusicItemSelected += MusicItem_MusicItemSelected;
                    musicItem.SelectedPanel.BorderRadius = 20;
                    flowLayoutPanel.Controls.Add(musicItem);
                }
            }
        }
        private void MusicItem_MusicItemSelected(object sender, string songPath)
        {
            OnMusicItemSelected(songPath);
        }
        protected virtual void OnMusicItemSelected(string songPath)
        {
            MusicItemSelected?.Invoke(this, songPath);
        }

        private void LongMusicItem_MouseHover(object sender, EventArgs e, SongInfo song)
        {
            if (sender is LongMusicItem musicItem)
            {
                musicItem.SelectedPanel.BackgroundColor = Color.DimGray; // Đổi màu nền khi chuột hover vào
            }
        }
    }
}
