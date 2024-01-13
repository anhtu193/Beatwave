using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beatwave.UserControlTabs;
using ComponentFactory.Krypton.Toolkit;
using WMPLib;

namespace Beatwave
{

    public partial class MainForm : KryptonForm
    {
        NavigationControl navigationControl;
        NavigationButton navigationButton;

        Color TabDefaultColor = Color.FromArgb(217, 217, 217);
        Color TabSelectedColor = Color.FromArgb(31, 223, 100);

        bool isPlaying;
        bool isDisplayingQueueTab;
        int displayingTab;
        int playmode; //0: repeat, 1: repeat once, 2: shuffle
        homeTab HomeTab;
        queueTab QueueTab;
        settingsTab SettingsTab;
        searchTab SearchTab;
        playlistTab PlaylistTab;

        public event EventHandler<string> CurrentSongChanged;
        public MainForm()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
            InitializeMusicPlayer();
            InitializePlayingSongBox();
        }

        private void InitializeMusicPlayer()
        {
            isPlaying = false;
            isDisplayingQueueTab = false;
            if (isPlaying == false)
            {
                play_button.Image = Properties.Resources.play;
            } 
            else
            {
                play_button.Image = Properties.Resources.pause;
            }
            btn_queue.Image = Properties.Resources.playlist;
            playmode = 0;
            btn_playmode.Image = Properties.Resources.repeat;
            CurrentSongChanged += HomeTab_MainForm_CurrentSongChanged;
            player.PlayStateChange += player_PlayStateChange;
            //player.settings.setMode("loop", true);
        }
        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                switch (playmode)
                {
                    case 0: // Lặp lại playlist
                        player.settings.setMode("shuffle", false);
                        break;
                    case 1: // Lặp lại bài hiện tại
                        player.settings.setMode("shuffle", false);
                        player.Ctlcontrols.previous();
                        UpdateCurrentSongInfo();

                        break;
                    case 2: // Phát ngẫu nhiên từ playlist
                        player.settings.setMode("shuffle", true);
                        break;
                }
            }
        }
        private void InitializeNavigationControl()
        {
            HomeTab = new homeTab();
            QueueTab = new queueTab();
            SettingsTab = new settingsTab();
            SearchTab = new searchTab();
            PlaylistTab = new playlistTab();
            PlaylistTab.MusicItemSelected += PlaylistTab_MusicItemSelected;
            SearchTab.MusicItemSelected += SearchTab_MusicItemSelected;
            QueueTab.MusicItemSelected += QueueTab_MusicItemSelected;
            HomeTab.PlaylistUpdated += HomeTab_PlaylistUpdated;
            HomeTab.MusicItemSelected += HomeTab_MusicItemSelected;      
            SettingsTab.FolderPathSelected += SettingsTab_FolderPathSelected;
            List<UserControl> tabList = new List<UserControl>()
            { HomeTab, SearchTab, PlaylistTab, QueueTab, SettingsTab};
            navigationControl = new NavigationControl(tabList, mainscreen_panel);
            navigationControl.Display(0);
            displayingTab = 0;          
        }

        private void SettingsTab_FolderPathSelected(object sender, string selectedFolderPath)
        {
            HomeTab.UpdateFolderPath(selectedFolderPath);
            // Load lại danh sách bài hát trong homeTab
            HomeTab.loadSongs();
            ResetUI();
        }

        private void HomeTab_MainForm_CurrentSongChanged(object sender, string songPath)
        {
            HomeTab.UpdateUI(isPlaying, new Mp3Reader().GetSongInfo(songPath));
            QueueTab.SetCurrentPlayingItem(songPath);
        }

        private void HomeTab_PlaylistUpdated(object sender, List<SongInfo> songs)
        {
            UpdateQueue(songs);
            
            QueueTab.SetPlaylist(songs);
            QueueTab.ResetSongList();
            QueueTab.DisplayMusicItems();

            SearchTab.SetPlaylist(songs);
            SearchTab.ResetSongList();
            SearchTab.DisplayMusicItems();

            PlaylistTab.getSongs(songs);
        }

        private void UpdateQueue(List<SongInfo> songs)
        {
            player.currentPlaylist.clear();
            IWMPPlaylist playlist = player.playlistCollection.newPlaylist("Main Playlist");
            player.currentPlaylist = playlist;

            foreach (var song in songs)
            {
                IWMPMedia media = player.newMedia(song.Path);
                player.currentPlaylist.appendItem(media);
            }
        }

        private void InitializePlayingSongBox()
        {
            songCover.BorderRadius = 15;
        }

        private void PlaylistTab_MusicItemSelected(object sender, string songPath)
        {
            PlayMusic(songPath);
        }
        private void HomeTab_MusicItemSelected(object sender, string songPath)
        {
            PlayMusic(songPath);
        }

        private void QueueTab_MusicItemSelected(object sender, string songPath)
        {
            PlayMusic(songPath);
        }

        private void SearchTab_MusicItemSelected(object sender, string songPath)
        {
            PlayMusic(songPath);
        }

        private void ResetUI()
        {
            songCover.Image = Properties.Resources.BeatwaveLogo;
            songArtist.Text = "";
            songTitle.Text = "";
            HomeTab.ResetUI();
        }
        public void PlayMusic(string songPath)
        {
            isPlaying = true;
            play_button.Image = Properties.Resources.pause;

            if (player.currentPlaylist != null)
            {
                IWMPPlaylist playlist = player.currentPlaylist;

                for (int i = 0; i < playlist.count; i++)
                {
                    IWMPMedia media = playlist.get_Item(i);

                    if (media.sourceURL == songPath)
                    {
                        player.Ctlcontrols.playItem(media);
                        break;
                    }
                }
            }


            if (System.IO.File.Exists(songPath))
            {
                Mp3Reader mp3Reader = new Mp3Reader();
                SongInfo songInfo = mp3Reader.GetSongInfo(songPath);
                string durationString = songInfo.Duration.ToString(@"mm\:ss");
                TimeSpan songDuration = songInfo.Duration;
                slider.Maximum = (int)songDuration.TotalSeconds;
                lb_duration.Text = durationString;
                timer1.Start();
                if (songInfo.Cover != null && songInfo.Cover.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(songInfo.Cover))
                    {
                        Image image = Image.FromStream(ms);
                        songCover.Image = image;
                    }
                }
                songArtist.Text = songInfo.Artist;
                songTitle.Text = songInfo.Title;
                wavegif.Visible = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tập tin âm thanh!");
            }
        }

        protected virtual void OnCurrentSongChanged(string songPath)
        {
            CurrentSongChanged?.Invoke(this, songPath);
        }

        private void lb_home_Click(object sender, EventArgs e)
        {
            btn_queue.Image = Properties.Resources.playlist;
            isDisplayingQueueTab = false;
            navigationControl.Display(0);
            displayingTab = 0;
            navigationButton.highlight(lb_home);
        }

        private void lb_search_Click(object sender, EventArgs e)
        {
            btn_queue.Image = Properties.Resources.playlist;
            isDisplayingQueueTab = false;
            navigationControl.Display(1);
            displayingTab = 1;
            navigationButton.highlight(lb_search);
        }

        private void lb_playlist_Click(object sender, EventArgs e)
        {
            btn_queue.Image = Properties.Resources.playlist;
            isDisplayingQueueTab = false;
            navigationControl.Display(2);
            displayingTab = 2;
            navigationButton.highlight(lb_playlist);
        }

        private void InitializeNavigationButton()
        {
            List<Label> tabLabels = new List<Label>() { lb_home, lb_search, lb_playlist, lb_settings };
            List<PictureBox> tabIcon = new List<PictureBox>() { ptb_home, ptb_search, ptb_playlist, ptb_settings };

            navigationButton = new NavigationButton(tabLabels, tabIcon, TabDefaultColor, TabSelectedColor);
            navigationButton.highlight(lb_home);
        }


        private void btn_queue_Click(object sender, EventArgs e)
        {
            isDisplayingQueueTab = !isDisplayingQueueTab;
            if (isDisplayingQueueTab == false)
            {
                btn_queue.Image = Properties.Resources.playlist;
                navigationControl.Display(displayingTab);
                if (displayingTab == 0)
                {
                    navigationButton.highlight(lb_home);
                }
                if (displayingTab == 1)
                {
                    navigationButton.highlight(lb_search);
                }
                if (displayingTab == 2)
                {
                    navigationButton.highlight(lb_playlist);
                }
                if (displayingTab == 4)
                {
                    navigationButton.highlight(lb_settings);
                }
            }
            else
            {
                btn_queue.Image = Properties.Resources.playlist_active;
                navigationControl.Display(3);
                navigationButton.highlight(label1);
            }
        }

        private void btn_playmode_Click(object sender, EventArgs e)
        {
            playmode++;
            if (playmode > 2) playmode = 0;
            if (playmode == 0)
            {
                btn_playmode.Image = Properties.Resources.repeat;
                player.settings.setMode("shuffle", false);
            }
            if (playmode == 1)
            {
                btn_playmode.Image = Properties.Resources.repeat_once;
                player.settings.setMode("shuffle", false);
            }
            if (playmode == 2)
            {
                btn_playmode.Image = Properties.Resources.shuffle;
                player.settings.setMode("shuffle", true);
            }
        }

        private void slider_volume_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            int volumePercentage = slider_volume.Value;
            int volume = (int)(volumePercentage * 1.0);

            player.settings.volume = volume;

            updateVolumeIcon(volumePercentage);
        }

        private void updateVolumeIcon(int volumePercentage)
        {
            if (volumePercentage == 0)
            {
                ptb_volume.Image = Properties.Resources.volume_mute;
            }
            else if (volumePercentage <= 50)
            {
                ptb_volume.Image = Properties.Resources.low_volume;
            }
            else
            {
                ptb_volume.Image = Properties.Resources.high_volume;
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            if (songTitle.Text != "")
            {
                isPlaying = !isPlaying;
                if (isPlaying == false)
                {
                    play_button.Image = Properties.Resources.play;
                    player.Ctlcontrols.pause();
                    wavegif.Visible = false;
                }
                else
                {
                    play_button.Image = Properties.Resources.pause;
                    player.Ctlcontrols.play();
                    wavegif.Visible = true;
                }
                HomeTab.UpdatePlayingState(isPlaying);
            } else
            {
                MessageBox.Show("Vui lòng chọn 1 bài hát!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_playtime.Text = player.Ctlcontrols.currentPositionString;
            slider.Value = (int)player.Ctlcontrols.currentPosition;
        }
         
        private void slider_ValueChanged_1(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            int newPosition = slider.Value;
            player.Ctlcontrols.currentPosition = newPosition;
        }
            
        private void slider_Click_1(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs.Button == MouseButtons.Left)
            {
                int newPosition = (int)(((float)mouseEventArgs.X / slider.Width) * slider.Maximum);
                player.Ctlcontrols.currentPosition = newPosition;
        
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (playmode != 1)
            {
                player.Ctlcontrols.next();
                UpdateCurrentSongInfo();
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (playmode != 1)
            {
                player.Ctlcontrols.previous();
                UpdateCurrentSongInfo();
            }
        }

        private void UpdateCurrentSongInfo()
        {
            string currentSongPath = GetCurrentSongPath();
            Mp3Reader mp3Reader = new Mp3Reader();
            SongInfo songInfo = mp3Reader.GetSongInfo(currentSongPath);
            string durationString = songInfo.Duration.ToString(@"mm\:ss");
            TimeSpan songDuration = songInfo.Duration;
            slider.Maximum = (int)songDuration.TotalSeconds;
            lb_duration.Text = durationString;
            timer1.Start();
            if (songInfo.Cover != null && songInfo.Cover.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(songInfo.Cover))
                {
                    Image image = Image.FromStream(ms);
                    songCover.Image = image;
                }
            }
            songArtist.Text = songInfo.Artist;
            songTitle.Text = songInfo.Title;
            wavegif.Visible = true;
            OnCurrentSongChanged(currentSongPath);
        }

        private string GetCurrentSongPath()
        {
            if (player.currentMedia != null)
            {
                return player.currentMedia.sourceURL;
            }

            return null;
        }

        private void player_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            if (isPlaying == true)
            {
                UpdateCurrentSongInfo();              
            }            
        }

        private void lb_settings_Click(object sender, EventArgs e)
        {
            isDisplayingQueueTab = false;
            btn_queue.Image = Properties.Resources.playlist;
            navigationControl.Display(4);
            displayingTab = 4;
            navigationButton.highlight(lb_settings);
        }
    }   
}
