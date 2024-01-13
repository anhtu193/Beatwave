using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
