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
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
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
    }
}
