using Beatwave.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beatwave.UserControlTabs
{
    public partial class searchTab : UserControl
    {
        List<SongInfo> playlist;
        public event EventHandler<string> MusicItemSelected;
        public searchTab()
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

        private void searchSong(string searchTerm)
        {
            flowLayoutPanel.Controls.Clear();
            if (playlist != null && playlist.Count > 0)
            {
                foreach (var song in playlist)
                {
                    if (song.Title.ToLower().Contains(searchTerm.ToLower()) || song.Artist.ToLower().Contains(searchTerm.ToLower()))
                    {
                        LongMusicItem musicItem = new LongMusicItem();
                        musicItem.Song = song;
                        musicItem.CoverImage.BorderRadius = 10;
                        musicItem.MusicItemSelected += MusicItem_MusicItemSelected;
                        musicItem.SelectedPanel.BorderRadius = 20;
                        flowLayoutPanel.Controls.Add(musicItem);
                    }              
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

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            searchSong(searchBar.Text);
        }
    }
}
