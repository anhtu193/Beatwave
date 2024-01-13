namespace Beatwave
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.player_panel = new System.Windows.Forms.Panel();
            this.songArtist = new System.Windows.Forms.Label();
            this.songTitle = new System.Windows.Forms.Label();
            this.songCover = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.slider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.slider_volume = new Bunifu.UI.WinForms.BunifuHSlider();
            this.ptb_volume = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lb_playtime = new System.Windows.Forms.Label();
            this.lb_duration = new System.Windows.Forms.Label();
            this.btn_previous = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_playmode = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_queue = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_next = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.play_button = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.wavegif = new System.Windows.Forms.PictureBox();
            this.navigation_panel = new System.Windows.Forms.Panel();
            this.ptb_settings = new System.Windows.Forms.PictureBox();
            this.lb_settings = new System.Windows.Forms.Label();
            this.ptb_playlist = new System.Windows.Forms.PictureBox();
            this.ptb_search = new System.Windows.Forms.PictureBox();
            this.ptb_home = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_playlist = new System.Windows.Forms.Label();
            this.lb_search = new System.Windows.Forms.Label();
            this.lb_home = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainscreen_panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_playmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_queue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavegif)).BeginInit();
            this.navigation_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player_panel
            // 
            this.player_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.player_panel.Controls.Add(this.songArtist);
            this.player_panel.Controls.Add(this.songTitle);
            this.player_panel.Controls.Add(this.songCover);
            this.player_panel.Controls.Add(this.slider);
            this.player_panel.Controls.Add(this.player);
            this.player_panel.Controls.Add(this.slider_volume);
            this.player_panel.Controls.Add(this.ptb_volume);
            this.player_panel.Controls.Add(this.lb_playtime);
            this.player_panel.Controls.Add(this.lb_duration);
            this.player_panel.Controls.Add(this.btn_previous);
            this.player_panel.Controls.Add(this.btn_playmode);
            this.player_panel.Controls.Add(this.btn_queue);
            this.player_panel.Controls.Add(this.btn_next);
            this.player_panel.Controls.Add(this.play_button);
            this.player_panel.Controls.Add(this.wavegif);
            this.player_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player_panel.Location = new System.Drawing.Point(0, 946);
            this.player_panel.Name = "player_panel";
            this.player_panel.Size = new System.Drawing.Size(1924, 109);
            this.player_panel.TabIndex = 0;
            // 
            // songArtist
            // 
            this.songArtist.AutoEllipsis = true;
            this.songArtist.Font = new System.Drawing.Font("Nunito", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songArtist.ForeColor = System.Drawing.Color.White;
            this.songArtist.Location = new System.Drawing.Point(117, 41);
            this.songArtist.Name = "songArtist";
            this.songArtist.Size = new System.Drawing.Size(217, 28);
            this.songArtist.TabIndex = 7;
            // 
            // songTitle
            // 
            this.songTitle.AutoEllipsis = true;
            this.songTitle.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTitle.ForeColor = System.Drawing.Color.White;
            this.songTitle.Location = new System.Drawing.Point(117, 10);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(217, 28);
            this.songTitle.TabIndex = 7;
            // 
            // songCover
            // 
            this.songCover.AllowFocused = false;
            this.songCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.songCover.AutoSizeHeight = true;
            this.songCover.BorderRadius = 0;
            this.songCover.Image = global::Beatwave.Properties.Resources.BeatwaveLogo;
            this.songCover.IsCircle = true;
            this.songCover.Location = new System.Drawing.Point(204, 10);
            this.songCover.Name = "songCover";
            this.songCover.Size = new System.Drawing.Size(87, 87);
            this.songCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songCover.TabIndex = 6;
            this.songCover.TabStop = false;
            this.songCover.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // slider
            // 
            this.slider.AllowCursorChanges = true;
            this.slider.AllowHomeEndKeysDetection = false;
            this.slider.AllowIncrementalClickMoves = false;
            this.slider.AllowMouseDownEffects = false;
            this.slider.AllowMouseHoverEffects = false;
            this.slider.AllowScrollingAnimations = false;
            this.slider.AllowScrollKeysDetection = false;
            this.slider.AllowScrollOptionsMenu = true;
            this.slider.AllowShrinkingOnFocusLost = false;
            this.slider.BackColor = System.Drawing.Color.Transparent;
            this.slider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slider.BackgroundImage")));
            this.slider.BindingContainer = null;
            this.slider.BorderRadius = 2;
            this.slider.BorderThickness = 1;
            this.slider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slider.DrawThickBorder = false;
            this.slider.DurationBeforeShrink = 2000;
            this.slider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.slider.LargeChange = 10;
            this.slider.Location = new System.Drawing.Point(504, 73);
            this.slider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slider.Maximum = 100;
            this.slider.Minimum = 0;
            this.slider.MinimumSize = new System.Drawing.Size(0, 31);
            this.slider.MinimumThumbLength = 18;
            this.slider.Name = "slider";
            this.slider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.slider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.slider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.slider.ScrollBarBorderColor = System.Drawing.Color.White;
            this.slider.ScrollBarColor = System.Drawing.Color.White;
            this.slider.ShrinkSizeLimit = 3;
            this.slider.Size = new System.Drawing.Size(552, 31);
            this.slider.SliderColor = System.Drawing.Color.White;
            this.slider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.slider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.slider.SmallChange = 1;
            this.slider.TabIndex = 0;
            this.slider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.slider.ThumbFillColor = System.Drawing.Color.Black;
            this.slider.ThumbLength = 54;
            this.slider.ThumbMargin = 1;
            this.slider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Small;
            this.slider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.slider.Value = 0;
            this.slider.Click += new System.EventHandler(this.slider_Click_1);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(20, 25);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(79, 62);
            this.player.TabIndex = 0;
            this.player.Visible = false;
            this.player.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.player_CurrentItemChange);
            // 
            // slider_volume
            // 
            this.slider_volume.AllowCursorChanges = true;
            this.slider_volume.AllowHomeEndKeysDetection = false;
            this.slider_volume.AllowIncrementalClickMoves = true;
            this.slider_volume.AllowMouseDownEffects = false;
            this.slider_volume.AllowMouseHoverEffects = false;
            this.slider_volume.AllowScrollingAnimations = true;
            this.slider_volume.AllowScrollKeysDetection = true;
            this.slider_volume.AllowScrollOptionsMenu = true;
            this.slider_volume.AllowShrinkingOnFocusLost = false;
            this.slider_volume.BackColor = System.Drawing.Color.Transparent;
            this.slider_volume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slider_volume.BackgroundImage")));
            this.slider_volume.BindingContainer = null;
            this.slider_volume.BorderRadius = 2;
            this.slider_volume.BorderThickness = 1;
            this.slider_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slider_volume.DrawThickBorder = false;
            this.slider_volume.DurationBeforeShrink = 2000;
            this.slider_volume.ElapsedColor = System.Drawing.Color.White;
            this.slider_volume.LargeChange = 10;
            this.slider_volume.Location = new System.Drawing.Point(1316, 44);
            this.slider_volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slider_volume.Maximum = 100;
            this.slider_volume.Minimum = 0;
            this.slider_volume.MinimumSize = new System.Drawing.Size(0, 31);
            this.slider_volume.MinimumThumbLength = 18;
            this.slider_volume.Name = "slider_volume";
            this.slider_volume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.slider_volume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.slider_volume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.slider_volume.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.slider_volume.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.slider_volume.ShrinkSizeLimit = 3;
            this.slider_volume.Size = new System.Drawing.Size(200, 31);
            this.slider_volume.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.slider_volume.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.slider_volume.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.slider_volume.SmallChange = 1;
            this.slider_volume.TabIndex = 5;
            this.slider_volume.ThumbColor = System.Drawing.Color.White;
            this.slider_volume.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.slider_volume.ThumbLength = 19;
            this.slider_volume.ThumbMargin = 1;
            this.slider_volume.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Small;
            this.slider_volume.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.slider_volume.Value = 50;
            this.slider_volume.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.slider_volume_ValueChanged);
            // 
            // ptb_volume
            // 
            this.ptb_volume.AllowFocused = false;
            this.ptb_volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptb_volume.AutoSizeHeight = true;
            this.ptb_volume.BorderRadius = 0;
            this.ptb_volume.Image = global::Beatwave.Properties.Resources.low_volume;
            this.ptb_volume.IsCircle = true;
            this.ptb_volume.Location = new System.Drawing.Point(1463, 44);
            this.ptb_volume.Name = "ptb_volume";
            this.ptb_volume.Size = new System.Drawing.Size(28, 28);
            this.ptb_volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_volume.TabIndex = 4;
            this.ptb_volume.TabStop = false;
            this.ptb_volume.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lb_playtime
            // 
            this.lb_playtime.AutoSize = true;
            this.lb_playtime.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_playtime.ForeColor = System.Drawing.Color.White;
            this.lb_playtime.Location = new System.Drawing.Point(451, 77);
            this.lb_playtime.Name = "lb_playtime";
            this.lb_playtime.Size = new System.Drawing.Size(49, 20);
            this.lb_playtime.TabIndex = 3;
            this.lb_playtime.Text = "00:00";
            // 
            // lb_duration
            // 
            this.lb_duration.AutoSize = true;
            this.lb_duration.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_duration.ForeColor = System.Drawing.Color.White;
            this.lb_duration.Location = new System.Drawing.Point(1062, 76);
            this.lb_duration.Name = "lb_duration";
            this.lb_duration.Size = new System.Drawing.Size(49, 20);
            this.lb_duration.TabIndex = 2;
            this.lb_duration.Text = "00:00";
            // 
            // btn_previous
            // 
            this.btn_previous.AllowFocused = false;
            this.btn_previous.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_previous.AutoSizeHeight = true;
            this.btn_previous.BorderRadius = 0;
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.Image = global::Beatwave.Properties.Resources.previous;
            this.btn_previous.IsCircle = true;
            this.btn_previous.Location = new System.Drawing.Point(904, 37);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(20, 20);
            this.btn_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_previous.TabIndex = 1;
            this.btn_previous.TabStop = false;
            this.btn_previous.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_playmode
            // 
            this.btn_playmode.AllowFocused = false;
            this.btn_playmode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_playmode.AutoSizeHeight = true;
            this.btn_playmode.BorderRadius = 0;
            this.btn_playmode.Image = global::Beatwave.Properties.Resources.repeat;
            this.btn_playmode.InitialImage = global::Beatwave.Properties.Resources.repeat;
            this.btn_playmode.IsCircle = true;
            this.btn_playmode.Location = new System.Drawing.Point(838, 36);
            this.btn_playmode.Name = "btn_playmode";
            this.btn_playmode.Size = new System.Drawing.Size(24, 24);
            this.btn_playmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_playmode.TabIndex = 1;
            this.btn_playmode.TabStop = false;
            this.btn_playmode.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btn_playmode.Click += new System.EventHandler(this.btn_playmode_Click);
            // 
            // btn_queue
            // 
            this.btn_queue.AllowFocused = false;
            this.btn_queue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_queue.AutoSizeHeight = true;
            this.btn_queue.BorderRadius = 0;
            this.btn_queue.Image = global::Beatwave.Properties.Resources.playlist;
            this.btn_queue.IsCircle = true;
            this.btn_queue.Location = new System.Drawing.Point(1107, 33);
            this.btn_queue.Name = "btn_queue";
            this.btn_queue.Size = new System.Drawing.Size(28, 28);
            this.btn_queue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_queue.TabIndex = 1;
            this.btn_queue.TabStop = false;
            this.btn_queue.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btn_queue.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // btn_next
            // 
            this.btn_next.AllowFocused = false;
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_next.AutoSizeHeight = true;
            this.btn_next.BorderRadius = 0;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Image = global::Beatwave.Properties.Resources.next;
            this.btn_next.IsCircle = true;
            this.btn_next.Location = new System.Drawing.Point(1047, 37);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(20, 20);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next.TabIndex = 1;
            this.btn_next.TabStop = false;
            this.btn_next.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // play_button
            // 
            this.play_button.AllowFocused = false;
            this.play_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play_button.AutoSizeHeight = true;
            this.play_button.BorderRadius = 22;
            this.play_button.Image = global::Beatwave.Properties.Resources.play;
            this.play_button.IsCircle = true;
            this.play_button.Location = new System.Drawing.Point(965, 25);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(45, 45);
            this.play_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play_button.TabIndex = 0;
            this.play_button.TabStop = false;
            this.play_button.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // wavegif
            // 
            this.wavegif.Image = global::Beatwave.Properties.Resources.giphy;
            this.wavegif.Location = new System.Drawing.Point(97, 36);
            this.wavegif.Name = "wavegif";
            this.wavegif.Size = new System.Drawing.Size(121, 95);
            this.wavegif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wavegif.TabIndex = 8;
            this.wavegif.TabStop = false;
            this.wavegif.Visible = false;
            // 
            // navigation_panel
            // 
            this.navigation_panel.BackColor = System.Drawing.Color.Black;
            this.navigation_panel.Controls.Add(this.ptb_settings);
            this.navigation_panel.Controls.Add(this.lb_settings);
            this.navigation_panel.Controls.Add(this.ptb_playlist);
            this.navigation_panel.Controls.Add(this.ptb_search);
            this.navigation_panel.Controls.Add(this.ptb_home);
            this.navigation_panel.Controls.Add(this.tableLayoutPanel1);
            this.navigation_panel.Controls.Add(this.label1);
            this.navigation_panel.Controls.Add(this.pictureBox1);
            this.navigation_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation_panel.Location = new System.Drawing.Point(0, 0);
            this.navigation_panel.Name = "navigation_panel";
            this.navigation_panel.Size = new System.Drawing.Size(267, 946);
            this.navigation_panel.TabIndex = 1;
            // 
            // ptb_settings
            // 
            this.ptb_settings.Image = global::Beatwave.Properties.Resources.settings;
            this.ptb_settings.Location = new System.Drawing.Point(47, 680);
            this.ptb_settings.Name = "ptb_settings";
            this.ptb_settings.Size = new System.Drawing.Size(32, 37);
            this.ptb_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_settings.TabIndex = 5;
            this.ptb_settings.TabStop = false;
            // 
            // lb_settings
            // 
            this.lb_settings.AutoSize = true;
            this.lb_settings.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lb_settings.Location = new System.Drawing.Point(92, 684);
            this.lb_settings.Name = "lb_settings";
            this.lb_settings.Size = new System.Drawing.Size(81, 28);
            this.lb_settings.TabIndex = 4;
            this.lb_settings.Text = "Cài đặt";
            this.lb_settings.Click += new System.EventHandler(this.lb_settings_Click);
            // 
            // ptb_playlist
            // 
            this.ptb_playlist.ErrorImage = global::Beatwave.Properties.Resources.home_unselected;
            this.ptb_playlist.Image = global::Beatwave.Properties.Resources.playlist_unselected;
            this.ptb_playlist.Location = new System.Drawing.Point(47, 448);
            this.ptb_playlist.Name = "ptb_playlist";
            this.ptb_playlist.Size = new System.Drawing.Size(32, 37);
            this.ptb_playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_playlist.TabIndex = 3;
            this.ptb_playlist.TabStop = false;
            // 
            // ptb_search
            // 
            this.ptb_search.ErrorImage = global::Beatwave.Properties.Resources.home_unselected;
            this.ptb_search.Image = global::Beatwave.Properties.Resources.search_unselected;
            this.ptb_search.Location = new System.Drawing.Point(47, 370);
            this.ptb_search.Name = "ptb_search";
            this.ptb_search.Size = new System.Drawing.Size(32, 37);
            this.ptb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_search.TabIndex = 2;
            this.ptb_search.TabStop = false;
            // 
            // ptb_home
            // 
            this.ptb_home.ErrorImage = global::Beatwave.Properties.Resources.home_unselected;
            this.ptb_home.Image = global::Beatwave.Properties.Resources.home_unselected;
            this.ptb_home.Location = new System.Drawing.Point(47, 298);
            this.ptb_home.Name = "ptb_home";
            this.ptb_home.Size = new System.Drawing.Size(32, 37);
            this.ptb_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_home.TabIndex = 0;
            this.ptb_home.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lb_playlist, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_search, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_home, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 280);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_playlist
            // 
            this.lb_playlist.BackColor = System.Drawing.Color.Black;
            this.lb_playlist.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_playlist.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_playlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lb_playlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_playlist.Location = new System.Drawing.Point(3, 148);
            this.lb_playlist.Name = "lb_playlist";
            this.lb_playlist.Size = new System.Drawing.Size(194, 76);
            this.lb_playlist.TabIndex = 2;
            this.lb_playlist.Text = "Thư viện";
            this.lb_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_playlist.Click += new System.EventHandler(this.lb_playlist_Click);
            // 
            // lb_search
            // 
            this.lb_search.BackColor = System.Drawing.Color.Black;
            this.lb_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_search.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lb_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_search.Location = new System.Drawing.Point(3, 74);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(194, 74);
            this.lb_search.TabIndex = 1;
            this.lb_search.Text = "Tìm kiếm";
            this.lb_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_search.Click += new System.EventHandler(this.lb_search_Click);
            // 
            // lb_home
            // 
            this.lb_home.BackColor = System.Drawing.Color.Black;
            this.lb_home.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_home.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lb_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_home.Location = new System.Drawing.Point(3, 0);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(194, 74);
            this.lb_home.TabIndex = 0;
            this.lb_home.Text = "Trang chủ";
            this.lb_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_home.Click += new System.EventHandler(this.lb_home_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nunito Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(50, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beatwave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Beatwave.Properties.Resources.Rectangle_41;
            this.pictureBox1.Location = new System.Drawing.Point(17, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainscreen_panel
            // 
            this.mainscreen_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainscreen_panel.Location = new System.Drawing.Point(267, 0);
            this.mainscreen_panel.Name = "mainscreen_panel";
            this.mainscreen_panel.Size = new System.Drawing.Size(1657, 946);
            this.mainscreen_panel.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.mainscreen_panel);
            this.Controls.Add(this.navigation_panel);
            this.Controls.Add(this.player_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beatwave";
            this.player_panel.ResumeLayout(false);
            this.player_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_playmode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_queue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavegif)).EndInit();
            this.navigation_panel.ResumeLayout(false);
            this.navigation_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel player_panel;
        private System.Windows.Forms.Panel navigation_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainscreen_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.PictureBox ptb_search;
        private System.Windows.Forms.PictureBox ptb_home;
        private System.Windows.Forms.Label lb_playlist;
        private System.Windows.Forms.PictureBox ptb_playlist;
        private Bunifu.UI.WinForms.BunifuHSlider slider;
        private Bunifu.UI.WinForms.BunifuPictureBox play_button;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_next;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_previous;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_queue;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_playmode;
        private System.Windows.Forms.Label lb_duration;
        private System.Windows.Forms.Label lb_playtime;
        private Bunifu.UI.WinForms.BunifuPictureBox ptb_volume;
        private Bunifu.UI.WinForms.BunifuHSlider slider_volume;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuPictureBox songCover;
        private System.Windows.Forms.Label songTitle;
        private System.Windows.Forms.Label songArtist;
        private System.Windows.Forms.PictureBox wavegif;
        private System.Windows.Forms.PictureBox ptb_settings;
        private System.Windows.Forms.Label lb_settings;
    }
}

