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
    public partial class Form2 : Form
    {
        bool isMaskSizeChosen;

        public Form2(System.Drawing.Image imageFrom_Form1)
        {
            InitializeComponent();
            pictureBox1.Image = imageFrom_Form1;
        }

        // saving an image somwhere on computer
        private void button2_Click(object sender, EventArgs e)
        {
            // presenting a new dialog to choose directory where image will be saved
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

        // applying low-pass filter
        private void button1_Click(object sender, EventArgs e)
        {
            // gotta get a mask size from a comboBox
            try
            {
                int maskSize = Convert.ToInt32(comboBox1.SelectedItem);
                // create a mask 
                double[,] Mask = new double[maskSize, maskSize];
                // fulfill it with 1's
                for (int i = 0; i<maskSize; i++)
                {
                    for (int j = 0; j <maskSize; j++)
                    {
                        Mask[i, j] = 1;
                    }
                }
                // now gotta take our image, especially its size
                int imageWidth = pictureBox1.Image.Width;
                int imageHeight = pictureBox1.Image.Height;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
