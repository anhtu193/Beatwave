﻿namespace Beatwave.UserControlTabs
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.titleSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_folder = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.btn_openFolder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btn_openFolder.CustomizableEdges = borderEdges5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito ExtraBold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "About Beatwave";
            // 
            // sourceCode
            // 
            this.sourceCode.AutoSize = true;
            this.sourceCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sourceCode.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceCode.ForeColor = System.Drawing.Color.White;
            this.sourceCode.Location = new System.Drawing.Point(20, 238);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.Size = new System.Drawing.Size(121, 28);
            this.sourceCode.TabIndex = 4;
            this.sourceCode.Text = "Source code";
            this.sourceCode.Click += new System.EventHandler(this.sourceCode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito ExtraBold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "About Us";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito ExtraBold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lý Thanh Tú Anh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito ExtraBold", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(291, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phạm Nguyễn Nhật Duy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Github";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(113, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Facebook";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(385, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "Facebook";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(292, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 28);
            this.label10.TabIndex = 8;
            this.label10.Text = "Github";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // settingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_openFolder);
            this.Controls.Add(this.ptb_folder);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sourceCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sourceCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
