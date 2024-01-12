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
           
            }

            private void InitializeNavigationControl()
            {
                HomeTab = new homeTab();
                HomeTab.PlaylistUpdated += HomeTab_PlaylistUpdated;
                HomeTab.MusicItemSelected += HomeTab_MusicItemSelected;                
                List<UserControl> tabList = new List<UserControl>()
                { HomeTab, new searchTab(), new playlistTab(), new queueTab()};
                navigationControl = new NavigationControl(tabList, mainscreen_panel);
                navigationControl.Display(0);
                displayingTab = 0;          
            }

            private void HomeTab_PlaylistUpdated(object sender, List<SongInfo> songs)
            {
                UpdateQueue(songs);           
            }

            private void UpdateQueue(List<SongInfo> songs)
            {
                player.currentPlaylist.clear();

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

            private void HomeTab_MusicItemSelected(object sender, string songPath)
            {
                PlayMusic(songPath);
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

            private void lb_home_Click(object sender, EventArgs e)
            {
                navigationControl.Display(0);
                displayingTab = 0;
                navigationButton.highlight(lb_home);
            }

            private void lb_search_Click(object sender, EventArgs e)
            {
                navigationControl.Display(1);
                displayingTab = 1;
                navigationButton.highlight(lb_search);
            }

            private void lb_playlist_Click(object sender, EventArgs e)
            {
                navigationControl.Display(2);
                displayingTab = 2;
                navigationButton.highlight(lb_playlist);
            }

            private void InitializeNavigationButton()
            {
                List<Label> tabLabels = new List<Label>() { lb_home, lb_search, lb_playlist };
                List<PictureBox> tabIcon = new List<PictureBox>() { ptb_home, ptb_search, ptb_playlist };

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
                }
                if (playmode == 1)
                {
                    btn_playmode.Image = Properties.Resources.repeat_once;
                }
                if (playmode == 2)
                {
                    btn_playmode.Image = Properties.Resources.shuffle;
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
        }
    }
