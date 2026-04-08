using obrazek;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoobchod
{
    public partial class Form1 : Form
    {

        private BitovaMapa btm;
        private Color vybranaBarva = Color.Black;
        private bool jeKresleniAktivni = false;
        private bool zobrazitPanely = false;
        private const int MaxBarev = 10; // Maximální počet barev pro zobrazení
        private const int PanelWidth = 30; // Šířka panelu
        private const int PanelHeight = 60; // Výška panelu
        private ColorPanelForm colorPanelForm;
        public Form1()
        {
            btm= new BitovaMapa();
            InitializeComponent();
            colorPanelForm = new ColorPanelForm();
            
        }

        private void zobraz4FotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btm.zobrazCtyry(new Point(), Form.ActiveForm);
            
        }

        private void otevřítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cesta;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "otevřít";
            
            ofd.Filter = "jpg obrázky (*.jpg)|*.jpg| jpeg obrázky (*.jpeg)|*.jpeg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                cesta = ofd.FileName;
                btm = new BitovaMapa(cesta); 
            }

            Form.ActiveForm.Width = btm.Bitmapa.Width + 200;
            Form.ActiveForm.Height = btm.Bitmapa.Height+60;
            btm.zobrazitBitovouMapu(new Point(0,0), Form.ActiveForm);
            
           

        }

        private void černobílýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bit1 = btm.Bitmapa;
            Bitmap bit2 = btm.Bitmapa;
            Color pixel;
            int svetelnost;
            for ( int i = 0; i < bit1.Width; i++)
            {
                for (int j = 0; j < bit1.Height; j++)
                {
                    pixel = bit1.GetPixel(i, j);
                    svetelnost = btm.svetelnost(pixel);
                    if (svetelnost > 127.5)
                    {
                        bit2.SetPixel (i, j, Color.White);
                    }
                    if(svetelnost < 127.5) 
                    {
                        bit2.SetPixel (i, j, Color.Black);
                    }  
                }
            }
            btm.Bitmapa = bit2;
            btm.zobrazitBitovouMapu(new Point(0, 0), Form.ActiveForm);
        }

        private void petodstinušediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bit1 = btm.Bitmapa;
            Bitmap bit2 = btm.Bitmapa;
            Bitmap bit3 = btm.Bitmapa;
            Bitmap bit4 = btm.Bitmapa;
            Bitmap bit5 = btm.Bitmapa;

            Color pixel;
            int svetelnost;
            for (int i = 0; i < bit1.Width; i++)
            {
                for (int j = 0; j < bit1.Height; j++)
                {
                    pixel = bit1.GetPixel(i, j);
                    svetelnost = btm.svetelnost(pixel);
                    if (svetelnost > 51)
                    {
                        bit2.SetPixel(i, j, Color.Black );
                    }
                    if (svetelnost > 102)
                    {
                        bit2.SetPixel(i, j, Color.LightSlateGray);
                    }
                    if(svetelnost > 153)
                    {
                        bit2.SetPixel(i,j, Color.LightGray);
                    }
                    if (svetelnost > 204)
                    {
                        bit2.SetPixel(i, j, Color.Silver);
                    }
                    if (svetelnost > 255)
                    {
                        bit2.SetPixel(i, j, Color.White);
                    }
                }
                btm.Bitmapa = bit2;
                btm.zobrazitBitovouMapu(new Point(0, 0), Form.ActiveForm);
            }

        }

        private void prolnutíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cesta1, cesta2;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Otevřít";
            ofd.Filter = "jpg obrázky (*.jpg)|*.jpg| jpeg obrázky (*.jpeg) |*.jpeg| png obrázky (*.png)|*.png";

            // obrázek
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cesta1 = ofd.FileName;
            }
            else
            {
                return; // zrušení vybírání obr.
            }

            // obrázek2
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cesta2 = ofd.FileName;
            }
            else
            {
                return;
            }
            // Načtení
            BitovaMapa btm1 = new BitovaMapa(cesta1);
            BitovaMapa btm2 = new BitovaMapa(cesta2);

            // prolnutím (smazu kazdemu obrazku pulku px a dosadím obr. dosebe)
            int sirkaVysledku = btm1.Bitmapa.Width + btm2.Bitmapa.Width;
            int vyskaVysledku = Math.Max(btm1.Bitmapa.Height, btm2.Bitmapa.Height);

            Bitmap vysledek = new Bitmap(sirkaVysledku, vyskaVysledku);

            // Prolnutí pixelů
            for (int i = 0; i < vysledek.Width; i++)
            {
                for (int j = 0; j < vysledek.Height; j++)
                {
                    Color pixel;
                    if (i % 2 == 0 && i < btm1.Bitmapa.Width)
                    {
                        if (j < btm1.Bitmapa.Height)
                        {
                            pixel = btm1.Bitmapa.GetPixel(i, j);
                        }
                        else
                        {
                            pixel = Color.Black; //pokud jsou jinak velké obr., tak se zbytky dopní černou
                        }
                    }
                    else if (i % 2 != 0 && i - 1 < btm2.Bitmapa.Width)
                    {
                        if (j < btm2.Bitmapa.Height)
                        {
                            pixel = btm2.Bitmapa.GetPixel(i - 1, j);
                        }
                        else
                        {
                            pixel = Color.Black;
                        }
                    }
                    else
                    {
                        pixel = Color.Black;
                    }

                    vysledek.SetPixel(i, j, pixel);
                }
            }

            // Zobrazení 
            Form fr1 = new Form();
            fr1.Name = "prolnutí";
            fr1.Size = new Size(sirkaVysledku, vyskaVysledku);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = vysledek;

            fr1.Controls.Add(pictureBox);
            fr1.Show();
        }





        private void převodDoJedneBarvyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            Bitmap image1 = btm.Bitmapa;
            Bitmap image2 = new Bitmap(image1);

            if (cd.ShowDialog() == DialogResult.OK)
            {
                Color barva = cd.Color;
                Color nbarva = barva;
                Color pixel1;
                for (int w = 0; w < image1.Width; w++)
                {
                    for (int h = 0; h < image1.Height; h++)
                    {
                        pixel1 = image1.GetPixel(w, h);
                        decimal svetelnost = btm.svetelnost(pixel1);
                        if (svetelnost > 51)//(svetelnost <= 50)
                        {
                            nbarva = Color.FromArgb(Convert.ToInt32(barva.R * 0.4), Convert.ToInt32(barva.G * 0.4), Convert.ToInt32(barva.B * 0.4));
                        }
                        if (svetelnost > 102)//((svetelnost >= 50)||(svetelnost <= 100))
                        {
                            nbarva = Color.FromArgb(Convert.ToInt32(barva.R * 0.5), Convert.ToInt32(barva.G * 0.5), Convert.ToInt32(barva.B * 0.5));
                        }
                        if (svetelnost > 153)//((svetelnost >= 100) || (svetelnost <= 150))
                        {
                            nbarva = Color.FromArgb(Convert.ToInt32(barva.R * 0.7), Convert.ToInt32(barva.G * 0.7), Convert.ToInt32(barva.B * 0.7));
                        }
                        if (svetelnost > 204)//((svetelnost >= 150) || (svetelnost <= 200))
                        {
                            nbarva = Color.FromArgb(Convert.ToInt32(barva.R * 0.9), Convert.ToInt32(barva.G * 0.9), Convert.ToInt32(barva.B * 0.9));
                        }
                        if (svetelnost > 255)//(svetelnost >= 200)
                        {
                            nbarva = Color.FromArgb(Convert.ToInt32(barva.R), Convert.ToInt32(barva.G), Convert.ToInt32(barva.B));
                        }
                        image2.SetPixel(w, h, nbarva);
                    }
                    btm.Bitmapa = image2;
                    btm.zobrazitBitovouMapu(new Point(0, 0), Form.ActiveForm);
                }
            }
        }

        private void zobrazitFotoToolStripMenuItem_Click(object sender, EventArgs e) 
        {

            btm.zobrazitBitovouMapu(new Point(0, 0), this);
        }

        private void šediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cesta;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Otevřít";
            ofd.Filter = "jpg obrázky (*.jpg)|*.jpg| jpeg obrázky (*.jpeg) |*.jpeg";

            // Vybrání obrázku
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cesta = ofd.FileName;
            }
            else
            {
                return; // Uživatel zrušil výběr obrázku
            }
            BitovaMapa btm = new BitovaMapa(cesta);
            Bitmap obrSedy = new Bitmap(btm.Bitmapa.Width, btm.Bitmapa.Height);

            // Konverze do odstínů šedi
            for (int i = 0; i < btm.Bitmapa.Width; i++)
            {
                for (int j = 0; j < btm.Bitmapa.Height; j++)
                {
                    Color pixel = btm.Bitmapa.GetPixel(i, j);

                    // Výpočet průměrné hodnoty barev
                    int prumer = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);

                    // Nastavení odstínu šedi pro nový pixel
                    Color novaBarva = Color.FromArgb(prumer, prumer, prumer);
                    obrSedy.SetPixel(i, j, novaBarva);
                }
            }

            // Zobrazení nového obrázku
            Form fr2 = new Form();
            fr2.Name = "šedý obrázek";
            fr2.Size = new Size(btm.Bitmapa.Width, btm.Bitmapa.Height);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = obrSedy;

            fr2.Controls.Add(pictureBox);
            fr2.Show();
        }

        private void reliefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap original = new Bitmap(btm.Bitmapa);
            Bitmap reliefImage = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color currentColor = original.GetPixel(x, y);
                    Color surroundingColor;

                    
                    if (x > 0 && y > 0)
                    {
                        surroundingColor = original.GetPixel(x - 1, y - 1);
                    }
                    else
                    {
                       
                        surroundingColor = currentColor;
                    }

                    // Výpočet rozdílu světelnosti pro vytvoření reliéfu
                    int intensityDiff = Math.Abs(svetelnost(currentColor) - svetelnost(surroundingColor));

                    // Omezíme hodnoty na rozsah 0-255
                    intensityDiff = Math.Min(255, Math.Max(0, intensityDiff));

                   
                    int newColorValue = 255 - intensityDiff;

                    Color newColor = Color.FromArgb(newColorValue, newColorValue, newColorValue);
                    reliefImage.SetPixel(x, y, newColor);
                }
            }
            btm.Bitmapa = reliefImage;
            btm.zobrazitBitovouMapu(new Point(0, 0), this);
        }

        private int svetelnost(Color pixel)
        {
            // Výpočet světelnosti na základě průměrné hodnoty barev (pro odstíny šedi)
            return (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
        }




        private void vyberbarvuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                vybranaBarva = colorDialog.Color;
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                jeKresleniAktivni = true;
                KreslitNaPozici(e.Location);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (jeKresleniAktivni)
            {
                KreslitNaPozici(e.Location);
            }
        }
        

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
            jeKresleniAktivni = false;
            }
        }

        private void KreslitNaPozici(Point pozice)
        {
            using (Graphics g = CreateGraphics())
            {
                g.FillEllipse(new SolidBrush(vybranaBarva), pozice.X - 2, pozice.Y - 2, 5, 5);
            }
        }

        private void barvaDoListuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zobrazitPanely = !zobrazitPanely; // Přepínáme příznak pro zobrazení panelů
            if (zobrazitPanely)
            {
                VytvorBarevnePanely();
            }
            else
            {
                OdstranBarevnePanely();
            }
            colorPanelForm.Show();
            
        }

        private void VytvorBarevnePanely()
        {
            int pocetBarev = 0;
            int panelLeft = 0;
            int panelTop = this.Height + 20; 

            foreach (Color color in barevnePanely.Keys.Take(MaxBarev))
            {
                Panel panel = barevnePanely[color];
                panel.Size = new Size(PanelWidth, PanelHeight);
                panel.BackColor = color;

                // Vytvoření nového panelu pod obrázkem
                Panel novyPanel = new Panel();
                novyPanel.Size = new Size(PanelWidth, PanelHeight);
                novyPanel.BackColor = color;

                Controls.Add(novyPanel);
                novyPanel.Location = new Point(panelLeft, panelTop);
                novyPanel.BringToFront();
                Refresh();

                // Přidání panelu do slovníku
                barevnePanely[color] = novyPanel;

                panelLeft += PanelWidth;
                pocetBarev++;

            }

            // Odstranění přebytečných barevných panelů
            if (pocetBarev < barevnePanely.Count)
            {
                for (int i = pocetBarev; i < barevnePanely.Count; i++)
                {
                    Panel panel = barevnePanely.Values.ElementAt(i);
                    Controls.Remove(panel);
                }
            }
        }

        private void OdstranBarevnePanely()
        {
            // Odstranění všech barevných panelů
            foreach (Panel panel in barevnePanely.Values)
            {
                Controls.Remove(panel);
            }

            barevnePanely.Clear();
            Refresh();
        }


        private Dictionary<Color, Panel> barevnePanely = new Dictionary<Color, Panel>(); //Slovník, který si bude pamatovat barvy, které jsem do něj již vložil

        private void Form1_Click(object sender, EventArgs e)
        {
            if (zobrazitPanely)
            {
                Point poziceKliku = PointToClient(MousePosition);
                Point originalImagePosition = btm.TransformToOriginalImage(poziceKliku);

                Color barvaPixelu = btm.GetPixelColorAt(originalImagePosition);

                if (!barevnePanely.ContainsKey(barvaPixelu))
                {
                    // Use the AddColorPanel method from ColorPanelForm
                    colorPanelForm.AddColorPanel(barvaPixelu);

                    // Přidání panelu do slovníku
                    barevnePanely.Add(barvaPixelu, null);
                }

                btm.zobrazitBitovouMapu(new Point(0, 0), this);
            }
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            // Přizpůsobení velikosti obrázku při změně velikosti formuláře
            btm.zobrazitBitovouMapu(new Point(0, 0), this);

            // Aktualizace pozice a velikosti barevných panelů
            if (zobrazitPanely)
            {
                OdstranBarevnePanely();
                VytvorBarevnePanely();
            }
        }

        private Bitmap CreateOmalovanka(Bitmap originalImage)
        {
            Bitmap omalovanka = new Bitmap(originalImage.Width, originalImage.Height);

            // Určete hodnotu prahu pro začátek vybarvování černě
            int threshold = 10;

            for (int x = 1; x < originalImage.Width - 1; x++)
            {
                for (int y = 1; y < originalImage.Height - 1; y++)
                {
                    Color pixel = originalImage.GetPixel(x, y);
                    Color surroundingColor = originalImage.GetPixel(x - 1, y);

                    int intensityDiff = Math.Abs(svetelnost(pixel) - svetelnost(surroundingColor));
                    intensityDiff = Math.Min(255, Math.Max(0, intensityDiff));

                    int newColorValue = 255 - intensityDiff;

                    // Změna barvy obrysu na černou, vyplnění na bílou
                    Color borderColor = Color.FromArgb(0, 0, 0);
                    Color fillColor = Color.White;

                    // Pokud je intenzita rozdílu dostatečně velká, nastavíme barvu na černou, jinak na bílou
                    Color newColor = intensityDiff > threshold ? borderColor : fillColor;

                    // Přidání původně barevných pixelů
                    if (intensityDiff <= threshold)
                    {
                        // Zesvětlení původní barvy (můžete experimentovat s hodnotou)
                        int lighteningFactor = 140;
                        int red = Math.Min(255, pixel.R + lighteningFactor);
                        int green = Math.Min(255, pixel.G + lighteningFactor);
                        int blue = Math.Min(255, pixel.B + lighteningFactor);

                        newColor = Color.FromArgb(red, green, blue);
                    }

                    omalovanka.SetPixel(x, y, newColor);
                }
            }

            return omalovanka;
        }

        private void omalovankaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cesta;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Otevřít";
            ofd.Filter = "jpg obrázky (*.jpg)|*.jpg| jpeg obrázky (*.jpeg) |*.jpeg| png obrázky (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cesta = ofd.FileName;
            }
            else
            {
                return; // Uživatel zrušil výběr obrázku
            }

            BitovaMapa btmOmalovanka = new BitovaMapa(cesta);
            Bitmap obrOmalovanka = CreateOmalovanka(btmOmalovanka.Bitmapa);

            // Zobrazení nového obrázku
            Form frOmalovanka = new Form();
            frOmalovanka.Name = "omalovanka";
            frOmalovanka.Size = new Size(btmOmalovanka.Bitmapa.Width, btmOmalovanka.Bitmapa.Height);

            PictureBox pictureBoxOmalovanka = new PictureBox();
            pictureBoxOmalovanka.Dock = DockStyle.Fill;
            pictureBoxOmalovanka.Image = obrOmalovanka;

            frOmalovanka.Controls.Add(pictureBoxOmalovanka);
            frOmalovanka.Show();
        }


        private void trideniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cesta;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "otevřít";
            ofd.Filter = "jpg obrázky (*.jpg)|*.jpg| jpeg obrázky (*.jpeg) |*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cesta = ofd.FileName;
                Bitmap loadedBitmap = new Bitmap(cesta); // Načtěte bitmapu ze souboru
                 Form2 form = new Form2(loadedBitmap); // Předejte načtenou bitmapu do konstruktoru trideni
                form.Width = loadedBitmap.Width + 200;
                form.Height = loadedBitmap.Height + 60;
                form.Show();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
        }

        private void zvětšeníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form4();
            form.Show();
        }

        private void aSCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form6();
            form.Show();
        }

        private void mapaBarevToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ColorMap();
            form.Show();
        }

        private void colorMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new matrix();
            form.Show();
        }

        private void hraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new hra();
            form.Show();
        }
    }
}

