using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace photoobchod
{
    public partial class Form3 : Form
    {
        private Bitmap btm;
        private Point startPoint;
        private Rectangle selectionRectangle;
        private int klik = 0;
        public Form3()
        {
            InitializeComponent();
        }


        private void VyrezObrazek()
        {
            if (selectionRectangle != null && btm != null)
            {
                Bitmap vyrez = new Bitmap(selectionRectangle.Width, selectionRectangle.Height);

                using (Graphics g = Graphics.FromImage(vyrez))
                {
                    g.DrawImage(btm, new Rectangle(0, 0, vyrez.Width, vyrez.Height),
                                    selectionRectangle, GraphicsUnit.Pixel);
                }

                Form vyrezForm = new Form();
                vyrezForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                vyrezForm.Text = "Výřez obrázku";
                vyrezForm.Size = new Size(vyrez.Width + 40, vyrez.Height + 40);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = vyrez;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += PictureBox_Click;

                vyrezForm.Controls.Add(pictureBox);
                vyrezForm.ShowDialog();
            }

            if (selectionRectangle == null)
            {
                MessageBox.Show("Vyber vyrez");
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (btm != null)
                    {
                        Bitmap vyrez = new Bitmap(selectionRectangle.Width, selectionRectangle.Height);

                        using (Graphics g = Graphics.FromImage(vyrez))
                        {
                            g.DrawImage(btm, new Rectangle(0, 0, vyrez.Width, vyrez.Height),
                                            selectionRectangle, GraphicsUnit.Pixel);
                        }

                        vyrez.Save(save.FileName);
                        MessageBox.Show("Obrázek uložen.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Není vybrán žádný obrázek.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }





        private void obrazekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Obrázky|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Všechny soubory|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        btm = new Bitmap(ofd.FileName);
                        this.BackgroundImage = btm;
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                        this.ClientSize = new Size(btm.Width, btm.Height);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nastala chyba při načítání obrázku: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mistoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klik = 1;
        }

        private void ukazatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VyrezObrazek();
        }


        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            if (klik == 1)
            {
                if (selectionRectangle != null)
                {
                    e.Graphics.DrawRectangle(Pens.Red, selectionRectangle);

                }
            }
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (klik == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = Math.Min(startPoint.X, e.X);
                    int y = Math.Min(startPoint.Y, e.Y);
                    int width = Math.Abs(startPoint.X - e.X);
                    int height = Math.Abs(startPoint.Y - e.Y);
                    selectionRectangle = new Rectangle(x, y, width, height);
                    this.Refresh();

                }
            }
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (klik == 1)
            {
                startPoint = e.Location;

            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            selectionRectangle = Rectangle.Empty;
            this.Refresh();
            klik = 0;
        }
    }
}
