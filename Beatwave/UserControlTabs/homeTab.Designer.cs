namespace Beatwave.UserControlTabs
{
    partial class homeTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.home_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.playing_artist_duration = new System.Windows.Forms.Label();
            this.playing_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playing_cover = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.home_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playing_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // home_panel
            // 
            this.home_panel.AutoScroll = true;
            this.home_panel.BackColor = System.Drawing.Color.Transparent;
            this.home_panel.Controls.Add(this.label3);
            this.home_panel.Controls.Add(this.playing_artist_duration);
            this.home_panel.Controls.Add(this.playing_title);
            this.home_panel.Controls.Add(this.label2);
            this.home_panel.Controls.Add(this.playing_cover);
            this.home_panel.Controls.Add(this.label1);
            this.home_panel.Controls.Add(this.flowLayoutPanel);
            this.home_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_panel.Location = new System.Drawing.Point(0, 0);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(1270, 738);
            this.home_panel.TabIndex = 0;
            this.home_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.home_panel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nunito Black", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1069, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "ĐANG PHÁT";
            // 
            // playing_artist_duration
            // 
            this.playing_artist_duration.AutoSize = true;
            this.playing_artist_duration.BackColor = System.Drawing.Color.Transparent;
            this.playing_artist_duration.Font = new System.Drawing.Font("Nunito SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.playing_artist_duration.ForeColor = System.Drawing.Color.White;
            this.playing_artist_duration.Location = new System.Drawing.Point(329, 330);
            this.playing_artist_duration.Name = "playing_artist_duration";
            this.playing_artist_duration.Size = new System.Drawing.Size(296, 33);
            this.playing_artist_duration.TabIndex = 5;
            this.playing_artist_duration.Text = "Chọn 1 bài hát để bắt đầu";
            // 
            // playing_title
            // 
            this.playing_title.AutoEllipsis = true;
            this.playing_title.Font = new System.Drawing.Font("Nunito Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playing_title.ForeColor = System.Drawing.Color.White;
            this.playing_title.Location = new System.Drawing.Point(321, 242);
            this.playing_title.Name = "playing_title";
            this.playing_title.Size = new System.Drawing.Size(907, 112);
            this.playing_title.TabIndex = 4;
            this.playing_title.Text = "Chào mừng đến với Beatwave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "TRANG CHỦ";
            // 
            // playing_cover
            // 
            this.playing_cover.AllowFocused = false;
            this.playing_cover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playing_cover.AutoSizeHeight = false;
            this.playing_cover.BorderRadius = 0;
            this.playing_cover.Image = global::Beatwave.Properties.Resources.BeatwaveLogo;
            this.playing_cover.IsCircle = false;
            this.playing_cover.Location = new System.Drawing.Point(18, 75);
            this.playing_cover.Name = "playing_cover";
            this.playing_cover.Size = new System.Drawing.Size(286, 286);
            this.playing_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playing_cover.TabIndex = 2;
            this.playing_cover.TabStop = false;
            this.playing_cover.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH BÀI HÁT";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 439);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1264, 267);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // homeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.home_panel);
            this.Name = "homeTab";
            this.Size = new System.Drawing.Size(1270, 738);
            this.Load += new System.EventHandler(this.homeTab_Load);
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playing_cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel home_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox playing_cover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playing_title;
        private System.Windows.Forms.Label playing_artist_duration;
        private System.Windows.Forms.Label label3;
    }
}
