using System;
using System.Drawing;
using System.Windows.Forms;

namespace photoobchod
{
    public partial class hra : Form
    {
        private Bitmap originalImage; // Původní načtený obrázek
        private PictureBox[,] puzzlePieces; // Pole pro ukládání jednotlivých částí puzzle
        private int pieceSize = 110; // Velikost jednotlivých dílků
        private int rows = 4; // Počet řádků (výchozí hodnota)
        private int cols = 4; // Počet sloupců (výchozí hodnota)
        private PictureBox selectedPiece = null; // Proměnná pro uchování vybraného dílku

        public hra()
        {
            InitializeComponent();
            InicializovatVlastniMenu(); // Inicializace vlastního menu pro výběr velikosti pole
        }

        private void InicializovatVlastniMenu()
        {
            ToolStripMenuItem velikostPoleMenu = new ToolStripMenuItem("Velikost pole");
            string[] poleVelikosti = { "4x4", "8x8", "16x16", "24x24", "48x48" }; // Možné velikosti pole
            foreach (string velikost in poleVelikosti)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(velikost);
                menuItem.Click += VelikostPoleMenuItem_Click;
                velikostPoleMenu.DropDownItems.Add(menuItem);
            }
            menuStrip1.Items.Add(velikostPoleMenu);
        }

        private void VelikostPoleMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            string[] sizeParts = menuItem.Text.Split('x');
            int selectedRows = int.Parse(sizeParts[0]);
            int selectedCols = int.Parse(sizeParts[1]);
            rows = selectedRows; // Nastavení počtu řádků podle výběru uživatele
            cols = selectedCols; // Nastavení počtu sloupců podle výběru uživatele
            if (puzzlePieces != null)
            {
                foreach (PictureBox piece in puzzlePieces)
                {
                    Controls.Remove(piece); // Odstranění starých částí puzzle z formuláře
                    piece.Dispose();
                }
            }
            SplitImage(); // Rozdělení nového obrázku na dílky
            ShufflePuzzlePieces(); // Proházení dílků po rozdělení
        }

        private void PuzzlePiece_Click(object sender, EventArgs e)
        {
            PictureBox clickedPiece = (PictureBox)sender;
            if (selectedPiece == null)
            {
                selectedPiece = clickedPiece; // Uložení kliknutého dílku jako vybraný
                selectedPiece.BorderStyle = BorderStyle.FixedSingle; // Zvýraznění vybraného dílku
            }
            else
            {
                ProhoditDilky(selectedPiece, clickedPiece); // Prohození vybraného dílku s kliknutým dílkem
                selectedPiece.BorderStyle = BorderStyle.None; // Zrušení zvýraznění vybraného dílku
                selectedPiece = null; // Nastavení vybraného dílku zpět na null
            }
            ZkontrolovatDokonceni(); // Zkontrolovat, zda je puzzle dokončeno
        }

        private void ProhoditDilky(PictureBox dil1, PictureBox dil2)
        {
            Point poloha1 = dil1.Location; // Uložení pozice prvního dílku
            object tag1 = dil1.Tag; // Uložení tagu prvního dílku
            dil1.Location = dil2.Location; // Přesunutí prvního dílku na pozici druhého
            dil1.Tag = dil2.Tag; // Nastavení tagu prvního dílku na tag druhého
            dil2.Location = poloha1; // Přesunutí druhého dílku na původní pozici prvního
            dil2.Tag = tag1; // Nastavení tagu druhého dílku na tag prvního
        }

        private void ZkontrolovatDokonceni()
        {
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (puzzlePieces[i, j].Tag != null && (int)puzzlePieces[i, j].Tag == count)
                    {
                        count++;
                    }
                }
            }
            if (count == rows * cols)
            {
                MessageBox.Show("Puzzle bylo úspěšně složeno!", "Gratulujeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void obrazekToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Obrázky|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                SplitImage(); // Rozdělení nově načteného obrázku na dílky
                ShufflePuzzlePieces(); // Proházení dílků po rozdělení
            }
        }

        private void SplitImage()
        {
            puzzlePieces = new PictureBox[rows, cols];

            int pieceWidth = originalImage.Width / cols;
            int pieceHeight = originalImage.Height / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Rectangle rect = new Rectangle(j * pieceWidth, i * pieceHeight, pieceWidth, pieceHeight);
                    Bitmap pieceBitmap = originalImage.Clone(rect, originalImage.PixelFormat);
                    puzzlePieces[i, j] = CreatePuzzlePiece(pieceBitmap);
                    puzzlePieces[i, j].Tag = i * cols + j; // Uložení indexu dílku
                    puzzlePieces[i, j].Click += PuzzlePiece_Click;
                    puzzlePieces[i, j].BorderStyle = BorderStyle.None;
                    puzzlePieces[i, j].Size = new Size(pieceSize, pieceSize);
                    puzzlePieces[i, j].Location = new Point(j * pieceSize, i * pieceSize);
                    Controls.Add(puzzlePieces[i, j]);
                }
            }
        }

        private PictureBox CreatePuzzlePiece(Bitmap pieceBitmap)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = pieceBitmap;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            return pictureBox;
        }

        private void ShufflePuzzlePieces()
        {
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int randomRow = rand.Next(0, rows);
                    int randomCol = rand.Next(0, cols);

                    ProhoditDilky(puzzlePieces[i, j], puzzlePieces[randomRow, randomCol]);
                }
            }
        }
    }
}
