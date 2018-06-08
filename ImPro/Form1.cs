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

        private void SetBrightness(object sender, EventArgs e)
        {
            try
            {
                /*
                Bitmap image = new Bitmap(pictureBox1.Image);
                Bitmap imageClone = (Bitmap)image.Clone();
                int current_brightness = trBar_Brightness.Value;
                int brightness;
                int prev_brightness = 0;

                txtBox_Brightness.Text = current_brightness.ToString();
                if (brightness - prev_brightness >= 0)
                {
                    pictureBox1.Image = Processing.imSetBrightness(imageClone, brightness);
                }
                else
                {
                    pictureBox1.Image = Processing.imSetBrightness(imageClone, -brightness);
                }
                */
            }
            catch
            {
                MessageBox.Show("A problem occured!");
            }
        }

        private void TrBar_Brightness_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
