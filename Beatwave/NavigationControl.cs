using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beatwave
{
    internal class NavigationControl
    {
        List<UserControl> tabList = new List<UserControl>();
        Panel panel;

        public NavigationControl(List<UserControl> tabList, Panel panel)
        {
            this.tabList = tabList;
            this.panel = panel;
            AddUserTabs();
        }

        private void AddUserTabs()
        {
            for (int i = 0; i < tabList.Count; i++)
            {
                tabList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(tabList[i]);
            }
        }

        public void Display(int index)
        {
            if (index < tabList.Count())
            {
                tabList[index].BringToFront();
            }
        }
    }
}
