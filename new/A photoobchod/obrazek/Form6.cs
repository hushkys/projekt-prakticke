using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace photoobchod
{
    public partial class Form6 : Form
    {
        private Bitmap bitmap;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void zobrazitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    bitmap = new Bitmap(ofd.FileName);
                    pictureBox1.Image = bitmap;
                    ShowPreview(); // Zobrazit náhled obrázku
                }
            }
        }

        private void ShowPreview()
        {
            Form previewForm = new Form();
            previewForm.Text = "Náhled obrázku";
            previewForm.ClientSize = new Size(bitmap.Width, bitmap.Height);
            PictureBox previewPictureBox = new PictureBox();
            previewPictureBox.Dock = DockStyle.Fill;
            previewPictureBox.Image = bitmap;
            previewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            previewForm.Controls.Add(previewPictureBox);
            previewForm.ShowDialog();
        }

        private void aSCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            if (bitmap == null)
            {
                MessageBox.Show("Nejprve načtěte obrázek.");
                return;
            }

            char[] asciiChars = { '@', '#', '8', '&', 'o', ':', '*', '.', ' ' }; // Nové znaky pro ASCII umění.

            StringBuilder asciiArt = new StringBuilder();

            float ratio = (float)bitmap.Width / bitmap.Height;

            //richTextBox1.Height = (int)(pictureBox1.Height * 0.9);
            //richTextBox1.Width = (int)(richTextBox1.Height * ratio);

            int fontSize = (int)Math.Min(richTextBox1.Width / ratio / bitmap.Width, richTextBox1.Height / bitmap.Height);

            for (int y = 0; y < bitmap.Height; y += fontSize)
            {
                for (int x = 0; x < bitmap.Width; x += fontSize)
                {
                    Color pixelColor = GetAverageColor(bitmap, x, y, Math.Min(fontSize, bitmap.Width - x), Math.Min(fontSize, bitmap.Height - y));
                    int brightness = (int)(pixelColor.GetBrightness() * (asciiChars.Length - 1)); // Index se mění podle jasu pixelu.
                    richTextBox1.SelectionColor = pixelColor;
                    asciiArt.Append(asciiChars[brightness]); // Vybrání znaku podle jasu.
                    asciiArt.Append(asciiChars[brightness]);
                }
                asciiArt.AppendLine();
            }

            richTextBox1.Font = new Font("Lucida Console", fontSize);
            richTextBox1.Text = asciiArt.ToString();
        }


        private Color GetAverageColor(Bitmap bitmap, int startX, int startY, int width, int height)
        {
            int totalRed = 0;
            int totalGreen = 0;
            int totalBlue = 0;

            int count = 0;

            for (int y = startY; y < startY + height; y++)
            {
                for (int x = startX; x < startX + width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    totalRed += pixelColor.R;
                    totalGreen += pixelColor.G;
                    totalBlue += pixelColor.B;
                    count++;
                }
            }

            if (count == 0) // Zamezení dělení nulou
                return Color.Black;

            int averageRed = totalRed / count;
            int averageGreen = totalGreen / count;
            int averageBlue = totalBlue / count;

            return Color.FromArgb(averageRed, averageGreen, averageBlue);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
