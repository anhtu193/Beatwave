using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beatwave.UserControlTabs
{
    public partial class settingsTab : UserControl
    {
        public event EventHandler<string> FolderPathSelected;
        public settingsTab()
        {
            InitializeComponent();
        }

        private void btn_openFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    path.Text = selectedFolder;
                    OnFolderPathSelected(selectedFolder);
                }
            }
        }

        protected virtual void OnFolderPathSelected(string selectedFolderPath)
        {
            FolderPathSelected?.Invoke(this, selectedFolderPath);
        }

        private void sourceCode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/anhtu193/Beatwave");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/anhtu193");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/193.anhtu");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/heluDuyne");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/hellominhtenDuy");
        }
    }
}
