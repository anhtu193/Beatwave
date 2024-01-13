namespace Beatwave.UserControls
{
    partial class LongMusicItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LongMusicItem));
            this.selectingPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.lb_duration = new System.Windows.Forms.Label();
            this.lb_artist = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.coverImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.selectingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // selectingPanel
            // 
            this.selectingPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.selectingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectingPanel.BackgroundImage")));
            this.selectingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectingPanel.BorderColor = System.Drawing.Color.Transparent;
            this.selectingPanel.BorderRadius = 20;
            this.selectingPanel.BorderThickness = 1;
            this.selectingPanel.Controls.Add(this.lb_duration);
            this.selectingPanel.Controls.Add(this.lb_artist);
            this.selectingPanel.Controls.Add(this.lb_title);
            this.selectingPanel.Controls.Add(this.coverImage);
            this.selectingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectingPanel.Location = new System.Drawing.Point(0, 0);
            this.selectingPanel.Name = "selectingPanel";
            this.selectingPanel.ShowBorders = true;
            this.selectingPanel.Size = new System.Drawing.Size(1200, 84);
            this.selectingPanel.TabIndex = 1;
            this.selectingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            // 
            // lb_duration
            // 
            this.lb_duration.AutoSize = true;
            this.lb_duration.Font = new System.Drawing.Font("Nunito SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_duration.ForeColor = System.Drawing.Color.White;
            this.lb_duration.Location = new System.Drawing.Point(1111, 28);
            this.lb_duration.Name = "lb_duration";
            this.lb_duration.Size = new System.Drawing.Size(58, 24);
            this.lb_duration.TabIndex = 3;
            this.lb_duration.Text = "02:54";
            this.lb_duration.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            // 
            // lb_artist
            // 
            this.lb_artist.Font = new System.Drawing.Font("Nunito", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_artist.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_artist.Location = new System.Drawing.Point(88, 44);
            this.lb_artist.Name = "lb_artist";
            this.lb_artist.Size = new System.Drawing.Size(974, 34);
            this.lb_artist.TabIndex = 2;
            this.lb_artist.Text = "Obito";
            this.lb_artist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Nunito Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(86, 10);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(976, 34);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Lost";
            this.lb_title.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            // 
            // coverImage
            // 
            this.coverImage.AllowFocused = false;
            this.coverImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coverImage.AutoSizeHeight = false;
            this.coverImage.BorderRadius = 0;
            this.coverImage.Image = global::Beatwave.Properties.Resources.obito;
            this.coverImage.IsCircle = true;
            this.coverImage.Location = new System.Drawing.Point(11, 8);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(67, 67);
            this.coverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverImage.TabIndex = 1;
            this.coverImage.TabStop = false;
            this.coverImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.coverImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            // 
            // LongMusicItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.selectingPanel);
            this.Name = "LongMusicItem";
            this.Size = new System.Drawing.Size(1200, 84);
            this.Load += new System.EventHandler(this.LongMusicItem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            this.selectingPanel.ResumeLayout(false);
            this.selectingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel selectingPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox coverImage;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_artist;
        private System.Windows.Forms.Label lb_duration;
    }
}
