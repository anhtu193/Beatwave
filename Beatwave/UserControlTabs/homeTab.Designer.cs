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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.home_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_panel
            // 
            this.home_panel.AutoScroll = true;
            this.home_panel.BackColor = System.Drawing.Color.Transparent;
            this.home_panel.Controls.Add(this.label1);
            this.home_panel.Controls.Add(this.flowLayoutPanel);
            this.home_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_panel.Location = new System.Drawing.Point(0, 0);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(1270, 738);
            this.home_panel.TabIndex = 0;
            this.home_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.home_panel_Paint);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(5, 348);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1264, 366);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH BÀI HÁT";
            // 
            // homeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.home_panel);
            this.Name = "homeTab";
            this.Size = new System.Drawing.Size(1270, 738);
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel home_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
