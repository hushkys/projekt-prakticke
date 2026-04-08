using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoobchod
{
    public partial class Form2 : Form
    {
        Button button;
        Bitmap bitmap;
        bool sortingInProgress = false;

        public Form2 (Bitmap loadedBitmap)
        {
            InitializeComponent();
            bitmap = loadedBitmap;
            InitializeButton();
        }

        private void InitializeButton()
        {
            button = new Button();
            button.Width = 100;
            button.Height = 30;
            button.Text = "Spustit třídění";
            button.Location = new Point(20, 20);
            button.Click += async (sender, e) => await SortBitmapAsync();
            Controls.Add(button);
        }

        private async Task SortBitmapAsync()
        {
            if (sortingInProgress)
                return;

            sortingInProgress = true;
            await Task.Run(() => SortBitmapWithVisualizationAsync(bitmap.Clone() as Bitmap));
            sortingInProgress = false;
        }

        private async Task SortBitmapWithVisualizationAsync(Bitmap bitmapToSort)
        {
            int width = bitmapToSort.Width;
            int height = bitmapToSort.Height;

            // Získání dat pixelů bitmapy pro práci přímo v paměti
            BitmapData bitmapData = bitmapToSort.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, bitmapToSort.PixelFormat);
            IntPtr ptr = bitmapData.Scan0;
            int bytes = Math.Abs(bitmapData.Stride) * height;
            byte[] rgbValues = new byte[bytes];
            Marshal.Copy(ptr, rgbValues, 0, bytes);

            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                // Třídění pixelů svisle
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height - 1; y++) // Upraveno: odstraněna -1, aby bylo možné pracovat se všemi řádky
                    {
                        int currentIndex = (y * bitmapData.Stride) + (x * 4);
                        int nextIndex = ((y + 1) * bitmapData.Stride) + (x * 4);

                        if (currentIndex < rgbValues.Length && nextIndex < rgbValues.Length)
                        {
                            Color currentPixel = Color.FromArgb(rgbValues[currentIndex + 3], rgbValues[currentIndex + 2], rgbValues[currentIndex + 1], rgbValues[currentIndex]);
                            Color nextPixel = Color.FromArgb(rgbValues[nextIndex + 3], rgbValues[nextIndex + 2], rgbValues[nextIndex + 1], rgbValues[nextIndex]);

                            if (IsDarker(currentPixel, nextPixel))
                            {
                                SwapPixels(rgbValues, currentIndex, nextIndex);
                                swapped = true;
                            }
                        }
                    }
                }

                // Aktualizace UI
                Marshal.Copy(rgbValues, 0, ptr, bytes);
                bitmapToSort.UnlockBits(bitmapData);
                RefreshBitmap(bitmapToSort);
                bitmapData = bitmapToSort.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, bitmapToSort.PixelFormat);
                ptr = bitmapData.Scan0;
                await Task.Delay(1); // Zpoždění pro vizualizaci
            }

            Marshal.Copy(rgbValues, 0, ptr, bytes);
            bitmapToSort.UnlockBits(bitmapData);
            RefreshBitmap(bitmapToSort);
        }

        private void RefreshBitmap(Bitmap bitmapToRefresh)
        {
            if (InvokeRequired)
            {
                Invoke((Action)(() => {
                    bitmap = bitmapToRefresh;
                    Refresh();
                }));
            }
            else
            {
                bitmap = bitmapToRefresh;
                Refresh();
            }
        }

        private bool IsDarker(Color color1, Color color2)
        {
            // Porovnání průměrné hodnoty barev pixelů
            int averageColor1 = (color1.R + color1.G + color1.B) / 3;
            int averageColor2 = (color2.R + color2.G + color2.B) / 3;
            return averageColor1 < averageColor2; // Změna podmínky - pokud je průměrná barva prvního pixelu tmavší než druhého, vrátí true
        }

        private void SwapPixels(byte[] rgbValues, int index1, int index2)
        {
            // Prohození hodnot RGB mezi dvěma pixely
            byte tempB = rgbValues[index1];
            byte tempG = rgbValues[index1 + 1];
            byte tempR = rgbValues[index1 + 2];
            byte tempA = rgbValues[index1 + 3];

            rgbValues[index1] = rgbValues[index2];
            rgbValues[index1 + 1] = rgbValues[index2 + 1];
            rgbValues[index1 + 2] = rgbValues[index2 + 2];
            rgbValues[index1 + 3] = rgbValues[index2 + 3];

            rgbValues[index2] = tempB;
            rgbValues[index2 + 1] = tempG;
            rgbValues[index2 + 2] = tempR;
            rgbValues[index2 + 3] = tempA;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(bitmap, new Point(20, 60));
        }
    }
}