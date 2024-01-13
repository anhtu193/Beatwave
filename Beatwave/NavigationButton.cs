using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Beatwave
{
    public class NavigationButton
    {
        List<Label> labels;
        List<PictureBox> pictureBoxes;
        Color defaultColor;
        Color selectedColor;

        public NavigationButton(List<Label> labels, List<PictureBox> pictureBoxes, Color defaultColor, Color selectedColor)
        {
            this.labels = labels;
            this.pictureBoxes = pictureBoxes;
            this.defaultColor = defaultColor;
            this.selectedColor = selectedColor;
            setLabelColor();
        }

        private void setLabelColor()
        {
            foreach(Label label in labels)
            {
                label.ForeColor = defaultColor;
            }
        }

        public void highlight(Label selectedLabel)
        {
            foreach(Label lbl in labels)
            {
                if (lbl == selectedLabel)
                {
                    lbl.ForeColor = selectedColor;               
                }
                else
                {
                    lbl.ForeColor = defaultColor;
                }
            }
            if (selectedLabel.Text == "Trang chủ")
            {
                pictureBoxes[0].Image = Properties.Resources.home_selected1;
                pictureBoxes[1].Image = Properties.Resources.search_unselected;
                pictureBoxes[2].Image = Properties.Resources.playlist_unselected;
                pictureBoxes[3].Image = Properties.Resources.settings;
            }
            if (selectedLabel.Text == "Tìm kiếm")
            {
                pictureBoxes[0].Image = Properties.Resources.home_unselected;
                pictureBoxes[1].Image = Properties.Resources.search_selected;
                pictureBoxes[2].Image = Properties.Resources.playlist_unselected;
                pictureBoxes[3].Image = Properties.Resources.settings;
            }
            if (selectedLabel.Text == "Thư viện")
            {
                pictureBoxes[0].Image = Properties.Resources.home_unselected;
                pictureBoxes[1].Image = Properties.Resources.search_unselected;
                pictureBoxes[2].Image = Properties.Resources.playlist_selected;
                pictureBoxes[3].Image = Properties.Resources.settings;
            }
            if (selectedLabel.Text == "Beatwave")
            {
                pictureBoxes[0].Image = Properties.Resources.home_unselected;
                pictureBoxes[1].Image = Properties.Resources.search_unselected;
                pictureBoxes[2].Image = Properties.Resources.playlist_unselected;
                pictureBoxes[3].Image = Properties.Resources.settings;
            }
            if (selectedLabel.Text == "Cài đặt")
            {
                pictureBoxes[0].Image = Properties.Resources.home_unselected;
                pictureBoxes[1].Image = Properties.Resources.search_unselected;
                pictureBoxes[2].Image = Properties.Resources.playlist_unselected;
                pictureBoxes[3].Image = Properties.Resources.settingsActive;
            }    
        }
    }
}
