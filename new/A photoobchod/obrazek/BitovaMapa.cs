using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace photoobchod
{
    internal class BitovaMapa
    {
        public string CestaKBitmape { get; set; }
        public string CestaKBitmape1 { get; set; }
        public string CestaKBitmape2 { get; set; }
        public string CestaKBitmape3 { get; set; }
        public Bitmap Bitmapa { get; set; }
        public Bitmap Bitmapa1 { get; set; }
        public Bitmap Bitmapa2 { get; set; }
        public Bitmap Bitmapa3 { get; set; }

        private const double svetlostR = 0.5;
        private const double svetlostG = 0.6;
        private const double svetlostB = 0.1;
        private string cesta;

        public BitovaMapa(Bitmap selectedImage)
        {
            cesta = @"";
            this.CestaKBitmape = Environment.CurrentDirectory + @"\kun.jpg";

            this.CestaKBitmape1 = Environment.CurrentDirectory + @"\kocka.jpg";
            this.CestaKBitmape2 = Environment.CurrentDirectory + @"\pes.jpg";
            this.CestaKBitmape3 = Environment.CurrentDirectory + @"\myval.jpg";

            this.Bitmapa = new Bitmap(this.CestaKBitmape);
            this.Bitmapa1 = new Bitmap(this.CestaKBitmape1);
            this.Bitmapa2 = new Bitmap(this.CestaKBitmape2);
            this.Bitmapa3 = new Bitmap(this.CestaKBitmape3);
        }

        public BitovaMapa(string cesta)
        {
            this.cesta = cesta;
            this.Bitmapa = new Bitmap(cesta);
        }

        public BitovaMapa()
        {
        }

        public void zobrazitBitovouMapu(Point point, Form activeForm)
        {
            Graphics gr = activeForm.CreateGraphics();
            gr.DrawImage(this.Bitmapa, point.X, point.Y, activeForm.Width, activeForm.Height);
            gr.Dispose();
            
        }
 
        public void zobrazCtyry(Point point, Form activeForm)
        {
            Graphics gr = activeForm.CreateGraphics();
            gr.DrawImage(this.Bitmapa, 0, 0, activeForm.Width/2, activeForm.Height/2);
            gr.DrawImage(this.Bitmapa1, activeForm.Width/2, activeForm.Height/2, activeForm.Width/2, activeForm.Height/2 );
            gr.DrawImage(this.Bitmapa2, 0, activeForm.Height/2, activeForm.Width/2 , activeForm.Height/2);
            gr.DrawImage(this.Bitmapa3, activeForm.Width/2, 0, activeForm.Width / 2, activeForm.Height / 2);
            gr.Dispose();
        }

        public int svetelnost(Color pixel)
        {
            return Convert.ToInt32(svetlostR*pixel.R + svetlostG*pixel.G + svetlostB*pixel.B);    
        }


        public Color GetPixelColorAt(Point pozice)
        {
            if (Bitmapa != null && pozice.X >= 0 && pozice.X < Bitmapa.Width && pozice.Y >= 0 && pozice.Y < Bitmapa.Height)
            {
                return Bitmapa.GetPixel(pozice.X, pozice.Y);
            }
            return Color.Black; // Nějaká výchozí barva, pokud pozice není v obrázku
        }
        public Point TransformToOriginalImage(Point resizedPosition)
        {
                // Check if Bitmapa is not null
            if (Bitmapa != null)
            {
                // Calculate the transformation based on the resizing ratio
                float xRatio = (float)Bitmapa.Width / Bitmapa1.Width; // Use the appropriate bitmap for width
                float yRatio = (float)Bitmapa.Height / Bitmapa1.Height; // Use the appropriate bitmap for height

                int originalX = (int)(resizedPosition.X * xRatio);
                int originalY = (int)(resizedPosition.Y * yRatio);

                return new Point(originalX, originalY);
            }
            else
            {
                // Handle the case where Bitmapa is null
                return resizedPosition; // Or provide a default value
            }
        }
    }
}
