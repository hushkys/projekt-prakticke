using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace obrazek
{
    public partial class matrix : Form
    {
        public Bitmap originalBitmap;
        public Bitmap workingBitmap;

        private float redIntensity = 1.0f;
        private float greenIntensity = 1.0f;
        private float blueIntensity = 1.0f;

        private float alphaIntensity = 1.0f;

        public matrix()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
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

        private void ApplyColorMatrix(float redIntensity, float greenIntensity, float blueIntensity)
        {
            ColorMatrix matrix = new ColorMatrix(new float[][] {
                new float[] { redIntensity, 0, 0, 0, 0 },   // Intenzita červené barvy
                new float[] { 0, greenIntensity, 0, 0, 0 }, // Intenzita zelené barvy
                new float[] { 0, 0, blueIntensity, 0, 0 },  // Intenzita modré barvy
                new float[] { 0, 0, 0, alphaIntensity, 0 },             // Intenzita alfa kanálu (průhlednosti)
                new float[] { 0, 0, 0, 0, 1 }              // Přidání posunu (není použito)
            });

            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix);

            using (Graphics g = Graphics.FromImage(workingBitmap))
            {
                g.DrawImage(originalBitmap, new Rectangle(0, 0, workingBitmap.Width, workingBitmap.Height),
                    0, 0, workingBitmap.Width, workingBitmap.Height, GraphicsUnit.Pixel, attributes);
            }

            pictureBox1.Image = workingBitmap;
            pictureBox1.Refresh();
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            redIntensity = (float)vScrollBar1.Value / 100.0f; // Hodnota posuvníku je v rozmezí 0-100, převedeme ji na hodnotu 0-1
            ApplyColorMatrix(redIntensity, greenIntensity, blueIntensity);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            greenIntensity = (float)vScrollBar2.Value / 100.0f;
            ApplyColorMatrix(redIntensity, greenIntensity, blueIntensity);
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            blueIntensity = (float)vScrollBar3.Value / 100.0f;
            ApplyColorMatrix(redIntensity, greenIntensity, blueIntensity);
        }

        private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            redIntensity = (float)vScrollBar4.Value / 100.0f;
            ApplyColorMatrix(redIntensity, greenIntensity, blueIntensity);
        }

        private void vScrollBar5_Scroll(object sender, ScrollEventArgs e)
        {
            greenIntensity = (float)vScrollBar5.Value / 100.0f;
            ApplyColorMatrix(redIntensity, greenIntensity, blueIntensity);
        }

        private void vScrollBar6_Scroll(object sender, ScrollEventArgs e)
        {
            blueIntensity = (float)vScrollBar6.Value / 100.0f;
            ApplyColorMatrix(redIntensity, greenIntensity, blueIntensity);
        }

        private void vScrollBar7_Scroll(object sender, ScrollEventArgs e)
        {
            redIntensity = (float)vScrollBar7.Value / 100.0f;
            ApplyColorMatrix(redIntensity, greenIntensity, blueIntensity);
        }

        private void vScrollBar8_Scroll(object sender, ScrollEventArgs e)
        {
            greenIntensity = (float)vScrollBar8.Value / 100.0f;
            ApplyColorMatrix(redIntensity, greenIntensity, blueIntensity);
        }

        private void vScrollBar9_Scroll(object sender, ScrollEventArgs e)
        {
            blueIntensity = (float)vScrollBar9.Value / 100.0f;
            ApplyColorMatrix(redIntensity, greenIntensity, blueIntensity);
        }

        private void vScrollBar10_Scroll(object sender, ScrollEventArgs e)
        {
            
            
        }
    }
}
