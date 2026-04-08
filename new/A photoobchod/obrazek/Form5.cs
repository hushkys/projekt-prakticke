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
    public partial class Form5 : Form
    {
        private Bitmap image;

        public Form5(Bitmap image)
        {
            InitializeComponent();
            this.image = image;
            this.ClientSize = image.Size; // Nastavení rozměrů formuláře podle rozměrů obrázku
            this.BackgroundImage = image;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
