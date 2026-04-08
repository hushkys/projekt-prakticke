using System;
using System.Drawing;
using System.Windows.Forms;

namespace photoobchod
{
    public partial class Form4 : Form
    {

        private Bitmap selectedBitmap;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void zvětšeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedBitmap != null)
            {
                Bitmap enlargedBitmap = EnlargeBitmap(selectedBitmap, 4);
                Form5 enlargedForm = new Form5(enlargedBitmap);
                enlargedForm.Show();
            }
            else
            {
                MessageBox.Show("Není načten žádný obrázek.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Bitmap EnlargeBitmap(Bitmap originalBitmap, int scaleFactor)
        {
            int newWidth = originalBitmap.Width * scaleFactor;
            int newHeight = originalBitmap.Height * scaleFactor;
            Bitmap enlargedBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(enlargedBitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                g.DrawImage(originalBitmap, 0, 0, newWidth, newHeight);
            }
            return enlargedBitmap;
        }


        private void zobrazitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Obrázky|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Vyberte obrázek";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedBitmap = new Bitmap(openFileDialog.FileName);
                    // Nastavte rozměry formuláře podle rozměrů načteného obrázku
                    this.ClientSize = new Size(selectedBitmap.Width, selectedBitmap.Height);
                    // Nastavte pozadí formuláře na načtený obrázek
                    this.BackgroundImage = selectedBitmap;
                    // Vyčistěte PictureBox, pokud byl používán
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nastala chyba při načítání obrázku: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
