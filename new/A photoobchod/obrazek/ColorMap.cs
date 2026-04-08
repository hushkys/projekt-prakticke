using System;
using System.Drawing;
using System.Windows.Forms;

namespace obrazek
{
    public partial class ColorMap : Form
    {
        private Bitmap originalBitmap;
        private Bitmap workingBitmap;
        private int tolerance = 25; // Tolerance pro odstíny barvy

        public ColorMap()
        {
            InitializeComponent();
        }

        private void ColorMap_Load(object sender, EventArgs e)
        {

        }

        private void obrázekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalBitmap = new Bitmap(openFileDialog.FileName);
                    workingBitmap = new Bitmap(originalBitmap); // Vytvoření kopie původního obrázku
                    pictureBox1.Image = workingBitmap;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (originalBitmap == null)
            {
                MessageBox.Show("Není načten žádný obrázek.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Získání barvy pixelu na který bylo kliknuto
            Color clickedColor = originalBitmap.GetPixel(e.X, e.Y);

            // Zobrazení palety barev pro výběr nové barvy
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;

                    // Vyhledání všech pixelů s podobnými odstíny barvy v původním obrázku
                    for (int x = 0; x < originalBitmap.Width; x++)
                    {
                        for (int y = 0; y < originalBitmap.Height; y++)
                        {
                            Color pixelColor = originalBitmap.GetPixel(x, y);
                            if (IsSimilarColor(pixelColor, clickedColor))
                            {
                                workingBitmap.SetPixel(x, y, selectedColor); // Použití pracovního obrázku pro změnu barev
                            }
                        }
                    }

                    pictureBox1.Image = workingBitmap; // Aktualizace zobrazení pracovního obrázku
                }
            }
        }

        private bool IsSimilarColor(Color color1, Color color2)
        {
            // Porovnání barev podle tolerance
            return Math.Abs(color1.R - color2.R) <= tolerance &&
                   Math.Abs(color1.G - color2.G) <= tolerance &&
                   Math.Abs(color1.B - color2.B) <= tolerance;
        }
    }
}
