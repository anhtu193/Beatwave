using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beatwave.UserControlTabs;
using ComponentFactory.Krypton.Toolkit;

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
        public MainForm()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
            InitializeMusicPlayer();
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
            homeTab HomeTab = new homeTab();
            HomeTab.MusicItemSelected += HomeTab_MusicItemSelected; // Đăng ký sự kiện từ homeTab
            List<UserControl> tabList = new List<UserControl>()
            { HomeTab, new searchTab(), new playlistTab(), new queueTab()};
            navigationControl = new NavigationControl(tabList, mainscreen_panel);
            navigationControl.Display(0);
            displayingTab = 0;
        }

        private void HomeTab_MusicItemSelected(object sender, string songPath)
        {
            PlayMusic(songPath);
        }

        public void PlayMusic(string songPath)
        {
            if (System.IO.File.Exists(songPath))
            {
                // Phát nhạc từ đường dẫn đã chọn
                player.URL = songPath;
                player.Ctlcontrols.play();
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

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            if (isPlaying == false)
            {
                play_button.Image = Properties.Resources.play;
            }
            else
            {
                play_button.Image = Properties.Resources.pause;
            }
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
            if (slider_volume.Value == 0) ptb_volume.Image = Properties.Resources.volume_mute;
            if (slider_volume.Value <= 50 && slider_volume.Value > 0) ptb_volume.Image = Properties.Resources.low_volume;
            if (slider_volume.Value > 50 && slider_volume.Value <= 100) ptb_volume.Image = Properties.Resources.high_volume;
        }
    }
}
