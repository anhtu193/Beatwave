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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.player_panel = new System.Windows.Forms.Panel();
            this.navigation_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_playlist = new System.Windows.Forms.Label();
            this.lb_search = new System.Windows.Forms.Label();
            this.lb_home = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainscreen_panel = new System.Windows.Forms.Panel();
            this.ptb_playlist = new System.Windows.Forms.PictureBox();
            this.ptb_search = new System.Windows.Forms.PictureBox();
            this.ptb_home = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_previous = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_queue = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_next = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.play_button = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.player_panel.SuspendLayout();
            this.navigation_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_queue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).BeginInit();
            this.SuspendLayout();
            // 
            // player_panel
            // 
            this.player_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.player_panel.Controls.Add(this.btn_previous);
            this.player_panel.Controls.Add(this.btn_queue);
            this.player_panel.Controls.Add(this.btn_next);
            this.player_panel.Controls.Add(this.play_button);
            this.player_panel.Controls.Add(this.bunifuHSlider1);
            this.player_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player_panel.Location = new System.Drawing.Point(0, 946);
            this.player_panel.Name = "player_panel";
            this.player_panel.Size = new System.Drawing.Size(1924, 109);
            this.player_panel.TabIndex = 0;
            // 
            // navigation_panel
            // 
            this.navigation_panel.BackColor = System.Drawing.Color.Black;
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
            this.lb_playlist.Text = "Playlist";
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
            this.label1.Location = new System.Drawing.Point(53, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beatwave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainscreen_panel
            // 
            this.mainscreen_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainscreen_panel.Location = new System.Drawing.Point(267, 0);
            this.mainscreen_panel.Name = "mainscreen_panel";
            this.mainscreen_panel.Size = new System.Drawing.Size(1657, 946);
            this.mainscreen_panel.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Beatwave.Properties.Resources.Rectangle_41;
            this.pictureBox1.Location = new System.Drawing.Point(20, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_previous
            // 
            this.btn_previous.AllowFocused = false;
            this.btn_previous.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_previous.AutoSizeHeight = true;
            this.btn_previous.BorderRadius = 0;
            this.btn_previous.Image = global::Beatwave.Properties.Resources.previous;
            this.btn_previous.IsCircle = true;
            this.btn_previous.Location = new System.Drawing.Point(904, 37);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(20, 20);
            this.btn_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_previous.TabIndex = 1;
            this.btn_previous.TabStop = false;
            this.btn_previous.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // btn_queue
            // 
            this.btn_queue.AllowFocused = false;
            this.btn_queue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_queue.AutoSizeHeight = true;
            this.btn_queue.BorderRadius = 0;
            this.btn_queue.Image = global::Beatwave.Properties.Resources.playlist;
            this.btn_queue.IsCircle = true;
            this.btn_queue.Location = new System.Drawing.Point(1105, 36);
            this.btn_queue.Name = "btn_queue";
            this.btn_queue.Size = new System.Drawing.Size(23, 23);
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
            this.btn_next.Image = global::Beatwave.Properties.Resources.next;
            this.btn_next.IsCircle = true;
            this.btn_next.Location = new System.Drawing.Point(1047, 37);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(20, 20);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next.TabIndex = 1;
            this.btn_next.TabStop = false;
            this.btn_next.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
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
            this.play_button.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // bunifuHSlider1
            // 
            this.bunifuHSlider1.AllowCursorChanges = true;
            this.bunifuHSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider1.AllowIncrementalClickMoves = true;
            this.bunifuHSlider1.AllowMouseDownEffects = false;
            this.bunifuHSlider1.AllowMouseHoverEffects = false;
            this.bunifuHSlider1.AllowScrollingAnimations = true;
            this.bunifuHSlider1.AllowScrollKeysDetection = true;
            this.bunifuHSlider1.AllowScrollOptionsMenu = true;
            this.bunifuHSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 2;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.bunifuHSlider1.LargeChange = 10;
            this.bunifuHSlider1.Location = new System.Drawing.Point(524, 74);
            this.bunifuHSlider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuHSlider1.Maximum = 100;
            this.bunifuHSlider1.Minimum = 0;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.White;
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.White;
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(552, 31);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.White;
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 0;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.Color.Black;
            this.bunifuHSlider1.ThumbLength = 54;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Small;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill;
            this.bunifuHSlider1.Value = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.mainscreen_panel);
            this.Controls.Add(this.navigation_panel);
            this.Controls.Add(this.player_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beatwave";
            this.player_panel.ResumeLayout(false);
            this.navigation_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_queue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
        private Bunifu.UI.WinForms.BunifuPictureBox play_button;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_next;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_previous;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_queue;
    }
}

