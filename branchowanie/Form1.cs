using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace branchowanie
{
    public partial class Form1 : Form
    {
        private Image originalImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Title = "Wybierz obraz";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = Image.FromFile(openFileDialog.FileName);
                    //pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Image = new Bitmap(originalImage);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }


        private int GetSelectedRotationAngle()
        {
            if (radioButton1.Checked)
                return 90;
            if (radioButton2.Checked)
                return 180;
            if (radioButton3.Checked)
                return 270;

            return 0;
        }
        private void bRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                return;

            int angle = GetSelectedRotationAngle();

            Image rotatedImage = (Image)originalImage.Clone();

            switch (angle)
            {
                case 90:
                    rotatedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 180:
                    rotatedImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 270:
                    rotatedImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
            }

            pictureBox1.Image = rotatedImage;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bInvert_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap invertedImage = InvertColors(new Bitmap(pictureBox1.Image));
                pictureBox1.Image = invertedImage;
            }
        }

        private Bitmap InvertColors(Bitmap bmp)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    bmp.SetPixel(x, y, invertedColor);
                }
            }
            return bmp;
        }

        private void bUpDo_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap flippedImage = new Bitmap(pictureBox1.Image);
                flippedImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Image = flippedImage;
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
