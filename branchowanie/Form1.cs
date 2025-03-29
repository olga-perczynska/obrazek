using System.Windows.Forms;

namespace branchowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki graficzne|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Wszystkie pliki|*.*";
                openFileDialog.Title = "Wybierz obraz";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void bGreen_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    if (!(pixel.G > pixel.R * 1.2 && pixel.G > pixel.B * 1.2)) 
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                }
            }

            pictureBox1.Image = bmp;
        }
    }
}
