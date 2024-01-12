namespace Beatwave.UserControls
{
    partial class MusicItem
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
            this.components = new System.ComponentModel.Container();
            this.coverImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_artist = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // coverImage
            // 
            this.coverImage.AllowFocused = false;
            this.coverImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coverImage.AutoSizeHeight = false;
            this.coverImage.BorderRadius = 0;
            this.coverImage.Image = global::Beatwave.Properties.Resources.obito;
            this.coverImage.IsCircle = true;
            this.coverImage.Location = new System.Drawing.Point(0, 0);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(192, 192);
            this.coverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverImage.TabIndex = 0;
            this.coverImage.TabStop = false;
            this.coverImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.coverImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            // 
            // lb_title
            // 
            this.lb_title.AutoEllipsis = true;
            this.lb_title.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(0, 199);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(192, 28);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Lost";
            this.lb_title.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            // 
            // lb_artist
            // 
            this.lb_artist.Font = new System.Drawing.Font("Nunito SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_artist.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_artist.Location = new System.Drawing.Point(0, 227);
            this.lb_artist.Name = "lb_artist";
            this.lb_artist.Size = new System.Drawing.Size(192, 23);
            this.lb_artist.TabIndex = 2;
            this.lb_artist.Text = "Obito";
            this.lb_artist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MusicItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_artist);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.coverImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MusicItem";
            this.Size = new System.Drawing.Size(195, 262);
            this.Load += new System.EventHandler(this.MusicItem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicItem_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox coverImage;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_artist;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
