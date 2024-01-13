namespace Beatwave.UserControlTabs
{
    partial class settingsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsTab));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.titleSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_folder = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.btn_openFolder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_folder)).BeginInit();
            this.SuspendLayout();
            // 
            // titleSettings
            // 
            this.titleSettings.AutoSize = true;
            this.titleSettings.Font = new System.Drawing.Font("Nunito ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSettings.ForeColor = System.Drawing.Color.White;
            this.titleSettings.Location = new System.Drawing.Point(18, 22);
            this.titleSettings.Name = "titleSettings";
            this.titleSettings.Size = new System.Drawing.Size(132, 38);
            this.titleSettings.TabIndex = 4;
            this.titleSettings.Text = "CÀI ĐẶT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito ExtraBold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thư viện nhạc";
            // 
            // ptb_folder
            // 
            this.ptb_folder.Image = global::Beatwave.Properties.Resources.file;
            this.ptb_folder.Location = new System.Drawing.Point(31, 119);
            this.ptb_folder.Name = "ptb_folder";
            this.ptb_folder.Size = new System.Drawing.Size(50, 39);
            this.ptb_folder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_folder.TabIndex = 5;
            this.ptb_folder.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Music folder location:";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.path.Location = new System.Drawing.Point(345, 127);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(189, 28);
            this.path.TabIndex = 4;
            this.path.Text = "No folder selected";
            // 
            // btn_openFolder
            // 
            this.btn_openFolder.AllowAnimations = true;
            this.btn_openFolder.AllowMouseEffects = true;
            this.btn_openFolder.AllowToggling = false;
            this.btn_openFolder.AnimationSpeed = 200;
            this.btn_openFolder.AutoGenerateColors = false;
            this.btn_openFolder.AutoRoundBorders = false;
            this.btn_openFolder.AutoSizeLeftIcon = true;
            this.btn_openFolder.AutoSizeRightIcon = true;
            this.btn_openFolder.BackColor = System.Drawing.Color.Transparent;
            this.btn_openFolder.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_openFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_openFolder.BackgroundImage")));
            this.btn_openFolder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openFolder.ButtonText = "Chọn thư mục";
            this.btn_openFolder.ButtonTextMarginLeft = 0;
            this.btn_openFolder.ColorContrastOnClick = 45;
            this.btn_openFolder.ColorContrastOnHover = 45;
            this.btn_openFolder.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_openFolder.CustomizableEdges = borderEdges2;
            this.btn_openFolder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_openFolder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_openFolder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_openFolder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_openFolder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_openFolder.Font = new System.Drawing.Font("Nunito SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFolder.ForeColor = System.Drawing.Color.White;
            this.btn_openFolder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openFolder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_openFolder.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_openFolder.IconMarginLeft = 11;
            this.btn_openFolder.IconPadding = 10;
            this.btn_openFolder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_openFolder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_openFolder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_openFolder.IconSize = 25;
            this.btn_openFolder.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_openFolder.IdleBorderRadius = 20;
            this.btn_openFolder.IdleBorderThickness = 1;
            this.btn_openFolder.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_openFolder.IdleIconLeftImage = null;
            this.btn_openFolder.IdleIconRightImage = null;
            this.btn_openFolder.IndicateFocus = false;
            this.btn_openFolder.Location = new System.Drawing.Point(1152, 116);
            this.btn_openFolder.Name = "btn_openFolder";
            this.btn_openFolder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_openFolder.OnDisabledState.BorderRadius = 20;
            this.btn_openFolder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openFolder.OnDisabledState.BorderThickness = 1;
            this.btn_openFolder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_openFolder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_openFolder.OnDisabledState.IconLeftImage = null;
            this.btn_openFolder.OnDisabledState.IconRightImage = null;
            this.btn_openFolder.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.btn_openFolder.onHoverState.BorderRadius = 20;
            this.btn_openFolder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openFolder.onHoverState.BorderThickness = 1;
            this.btn_openFolder.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.btn_openFolder.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_openFolder.onHoverState.IconLeftImage = null;
            this.btn_openFolder.onHoverState.IconRightImage = null;
            this.btn_openFolder.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_openFolder.OnIdleState.BorderRadius = 20;
            this.btn_openFolder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openFolder.OnIdleState.BorderThickness = 1;
            this.btn_openFolder.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_openFolder.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_openFolder.OnIdleState.IconLeftImage = null;
            this.btn_openFolder.OnIdleState.IconRightImage = null;
            this.btn_openFolder.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_openFolder.OnPressedState.BorderRadius = 20;
            this.btn_openFolder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openFolder.OnPressedState.BorderThickness = 1;
            this.btn_openFolder.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_openFolder.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_openFolder.OnPressedState.IconLeftImage = null;
            this.btn_openFolder.OnPressedState.IconRightImage = null;
            this.btn_openFolder.Size = new System.Drawing.Size(150, 39);
            this.btn_openFolder.TabIndex = 6;
            this.btn_openFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_openFolder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_openFolder.TextMarginLeft = 0;
            this.btn_openFolder.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_openFolder.UseDefaultRadiusAndThickness = true;
            this.btn_openFolder.Click += new System.EventHandler(this.btn_openFolder_Click);
            // 
            // settingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Controls.Add(this.btn_openFolder);
            this.Controls.Add(this.ptb_folder);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleSettings);
            this.Name = "settingsTab";
            this.Size = new System.Drawing.Size(1270, 738);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_folder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_folder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label path;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_openFolder;
    }
}
