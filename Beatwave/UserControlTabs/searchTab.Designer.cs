namespace Beatwave.UserControlTabs
{
    partial class searchTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchTab));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.title = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Nunito ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(16, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(145, 38);
            this.title.TabIndex = 7;
            this.title.Text = "TÌM KIẾM";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(16, 131);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1293, 604);
            this.flowLayoutPanel.TabIndex = 9;
            // 
            // searchBar
            // 
            this.searchBar.AcceptsReturn = false;
            this.searchBar.AcceptsTab = false;
            this.searchBar.AnimationSpeed = 10;
            this.searchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBar.BackColor = System.Drawing.Color.Transparent;
            this.searchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBar.BackgroundImage")));
            this.searchBar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchBar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchBar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchBar.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchBar.BorderRadius = 20;
            this.searchBar.BorderThickness = 1;
            this.searchBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.DefaultFont = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.DefaultText = "";
            this.searchBar.FillColor = System.Drawing.Color.White;
            this.searchBar.HideSelection = true;
            this.searchBar.IconLeft = global::Beatwave.Properties.Resources.search_unselected;
            this.searchBar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.IconPadding = 10;
            this.searchBar.IconRight = null;
            this.searchBar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.Lines = new string[0];
            this.searchBar.Location = new System.Drawing.Point(16, 73);
            this.searchBar.MaxLength = 32767;
            this.searchBar.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchBar.Modified = false;
            this.searchBar.Multiline = false;
            this.searchBar.Name = "searchBar";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBar.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchBar.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBar.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBar.OnIdleState = stateProperties8;
            this.searchBar.Padding = new System.Windows.Forms.Padding(3);
            this.searchBar.PasswordChar = '\0';
            this.searchBar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBar.PlaceholderText = "Nhập tên bài hát, tên nghệ sĩ";
            this.searchBar.ReadOnly = false;
            this.searchBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBar.SelectedText = "";
            this.searchBar.SelectionLength = 0;
            this.searchBar.SelectionStart = 0;
            this.searchBar.ShortcutsEnabled = true;
            this.searchBar.Size = new System.Drawing.Size(1238, 52);
            this.searchBar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchBar.TabIndex = 10;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBar.TextMarginBottom = 0;
            this.searchBar.TextMarginLeft = 3;
            this.searchBar.TextMarginTop = 0;
            this.searchBar.TextPlaceholder = "Nhập tên bài hát, tên nghệ sĩ";
            this.searchBar.UseSystemPasswordChar = false;
            this.searchBar.WordWrap = true;
            this.searchBar.TextChange += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // searchTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Nunito", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "searchTab";
            this.Size = new System.Drawing.Size(1270, 738);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuTextBox searchBar;
    }
}
