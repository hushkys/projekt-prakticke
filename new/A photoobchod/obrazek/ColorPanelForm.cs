using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoobchod
{
    public partial class ColorPanelForm : Form
    {
        public ColorPanelForm()
        {
            InitializeComponent();
        }

        public void AddColorPanel(Color color)
        {
            Panel newPanel = new Panel();
            newPanel.Size = new Size(30, 60);
            newPanel.BackColor = color;
            flowLayoutPanel1.Controls.Add(newPanel);
        }
    }
}
