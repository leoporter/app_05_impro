using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imLoad(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();               // okienko otwarcia systemu plików
            dialog.Filter = "All files (*.*)|*.*";                      // pokazuj wszystkie pliki
            dialog.InitialDirectory = "C:\\";                           // początkowa ścieżka
            dialog.Title = "Select an image file";                      // tytuł okienka
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fname = dialog.FileName;                         // nazwa pliku 
                pictureBox1.Image = new Bitmap(dialog.FileName);        // nowa bitmapa - taka jak otwarty obraz
                textBox2.Text = pictureBox1.Image.Width.ToString();     // wyświetl szerokość obrazu
                textBox1.Text = pictureBox1.Image.Height.ToString();    // wyświetl wysokość obrazu
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;     // dopasowanie wymiaru obrazu do picture Boxa
            }
            dialog.Dispose();
        }

        private void imSave(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();                       // okienko zapisu pliku
            try
            {
                dialog.InitialDirectory = "C:\\";                               // początkowa ścieżka
                dialog.Title = "Save a new image";                              // nazwa okienka
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fname = dialog.FileName;                             // nazwa pliku
                    pictureBox1.Image.Save(dialog.FileName, ImageFormat.Jpeg);  // zapisz (nazwa pliku, format)
                    MessageBox.Show("Operation succedded!");
                }
                else
                {
                    MessageBox.Show("Saving failed!");
                }

            }
            catch
            {
                MessageBox.Show("A problem occured!");
            }
        }

        private void btn_Gray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(pictureBox1.Image);
            try
            {
                pictureBox1.Image = Processing.imToGray(copy);          // wykorzystanie funkcji z klasy Processing do wyszarzenia obrazu :D
            }
            catch
            {
                MessageBox.Show("Operation failed!");
            }

        }

        private void btn_CountPixels_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);

            try
            {
                textBox3.Text = Processing.imCountPixels(image).ToString(); // użycie na obrazie metody do policzenia liczby pikseli w obrazie
            }
            catch
            {
                throw;
            }
        }

        protected void imLowPassFilter(object sender, EventArgs e)          // przejście do wyboru filtra
        {
            Image copy = pictureBox1.Image;
            Form3 form = new Form3(copy);
            form.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int prev = 0;

        private void SetBrightness(object sender, EventArgs e)
        {
            try
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                int brightness = trBar_Brightness.Value;
                txtBox_Brightness.Text = brightness.ToString();
                
                if (brightness - prev >= 0)
                {
                    pictureBox1.Image = Processing.imSetBrightness(image, brightness);
                }
                else
                {
                    pictureBox1.Image = Processing.imSetBrightness(image, -brightness);
                }
                prev = brightness;

            }
            catch
            {
                MessageBox.Show("A problem occured!");
            }
        }

        private void TrBar_Brightness_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Click_Invert(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Processing.imSetInvert(image);
        }

        private void btn_Click_CompareRGBWeights(object sender, EventArgs e)
        {
            try
            {
                Image copy = pictureBox1.Image;
                Form4 form4 = new Form4(copy);
                form4.Show();
            }
            catch
            {
                MessageBox.Show("A problem occured!");
            }
        }

        private void btn_Click_Rotate(object sender, EventArgs e)
        {
            pictureBox1.Image = Processing2.imRotate((Bitmap)pictureBox1.Image);
        }
    }
}
