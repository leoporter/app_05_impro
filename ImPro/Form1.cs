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

        private void button1_Click(object sender, EventArgs e)
        {
            // okienko otwarcia systemu plików
            OpenFileDialog dialog = new OpenFileDialog();
            // pokazuj wszystkie pliki
            dialog.Filter = "All files (*.*)|*.*";
            // początkowa ścieżka
            dialog.InitialDirectory = "C:\\";
            // tytuł okienka
            dialog.Title = "Select an image file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // nazwa pliku 
                string fname = dialog.FileName;
                // nowa bitmapa - taka jak otwarty obraz
                pictureBox1.Image = new Bitmap(dialog.FileName);
                // wyświetl szerokość obrazu
                textBox2.Text = pictureBox1.Image.Width.ToString();
                // wyświetl wysokość obrazu
                textBox1.Text = pictureBox1.Image.Height.ToString();
            }
            dialog.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // nowa bitmapa - na szary obraz
            Bitmap newBitmap = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

            try
            {
                //get a graphics object from the new image
                Graphics g = Graphics.FromImage(newBitmap);

                //create the grayscale ColorMatrix
                ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                   {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                   });

                //create some image attributes
                ImageAttributes attributes = new ImageAttributes();

                //set the color matrix attribute
                attributes.SetColorMatrix(colorMatrix);

                //draw the original image on the new image
                //using the grayscale color matrix
                g.DrawImage(pictureBox1.Image, new Rectangle(0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height),
                   0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height, GraphicsUnit.Pixel, attributes);
                pictureBox1.Image = newBitmap;
                //dispose the Graphics object
                g.Dispose();
            }

            catch
            {
                MessageBox.Show("Image could not be converted into grayscale!");
            }
        }

        // saving our image
        private void button3_Click(object sender, EventArgs e)
        {
            // okienko zapisu pliku
            SaveFileDialog dialog = new SaveFileDialog();
            try
            {
                // początkowa ścieżka
                dialog.InitialDirectory = "C:\\";
                // nazwa okienka
                dialog.Title = "Save a new image";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // nazwa pliku
                    string fname = dialog.FileName;
                    // zapisz (nazwa pliku, format)
                    pictureBox1.Image.Save(dialog.FileName, ImageFormat.Jpeg);
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

        // count unique pixels in an image
        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            HashSet<Color> colors = new HashSet<Color>();
            Bitmap image = new Bitmap(pictureBox1.Image);

            try
            {
                if (image != null)
                {
                    for (int i = 0; i < image.Size.Width; i++)
                    {
                        for (int j = 0; j < image.Size.Height; j++)
                        {
                            colors.Add(image.GetPixel(i, j));
                        }
                    }
                    count = colors.Count;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                colors.Clear();
                image.Dispose();
            }

            textBox3.Text = count.ToString();
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
        // if it was clicked it means you wanna use a low-pass filter 
        private void button5_Click(object sender, EventArgs e)
        {
            // passing in constructor an image from Form1
            Form2 form2 = new Form2(pictureBox1.Image);
            form2.Show();
        }

        // point processing of an image
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double gamma = trackBar1.Value; 
        }
    }
}
