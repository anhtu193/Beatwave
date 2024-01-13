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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Beatwave.UserControlTabs
{
    public partial class playlistTab : UserControl
    {
        List<SongInfo> songList;
        public event EventHandler<string> MusicItemSelected;
        public playlistTab()
        {
            InitializeComponent();
            flowLayoutPanel.AutoScroll = true;
            
        }

        public void getSongs(List<SongInfo> receivedPlaylist)
        {
            songList = receivedPlaylist;
            sortCombobox.SelectedIndex = 0;
        }

        private void LoadSongs()
        {
            // Group songs by the selected sort mode
            var groupedSongs = GroupSongsBySortMode(songList);

            // Display songs in the FlowLayoutPanel
            DisplayGroupedSongs(groupedSongs);
           
        }

        private Dictionary<string, List<SongInfo>> GroupSongsBySortMode(List<SongInfo> songs)
        {
            string sortMode = sortCombobox.SelectedItem?.ToString();

            if (sortMode == "A - Z")
            {
                return songs.GroupBy(song => song.Title.Substring(0, 1)).ToDictionary(g => g.Key, g => g.ToList());
            }
            else if (sortMode == "Artist")
            {
                return songs.GroupBy(song => song.Artist).ToDictionary(g => g.Key, g => g.ToList());
            }

            return new Dictionary<string, List<SongInfo>>();
        }

        private void DisplayGroupedSongs(Dictionary<string, List<SongInfo>> groupedSongs)
        {
            foreach (var group in groupedSongs)
            {
                string groupName = group.Key;

                // Add group header
                Label groupLabel = new Label();
                groupLabel.ForeColor = Color.White;
                groupLabel.Text = groupName;
                groupLabel.AutoSize = false;
                groupLabel.Width = 600;
                groupLabel.Font = new Font("Nunito", 14, FontStyle.Bold);
                flowLayoutPanel.Controls.Add(groupLabel);

                // Add songs to the FlowLayoutPanel under the group
                foreach (var song in group.Value)
                {
                    LongMusicItem musicItem = new LongMusicItem();
                    musicItem.Song = song;
                    musicItem.MusicItemSelected += MusicItem_MusicItemSelected;
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
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reload songs when the sort mode changes
            flowLayoutPanel.Controls.Clear();
            LoadSongs();
        }
    }
}
