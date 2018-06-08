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

        public Form2(System.Drawing.Image imageFrom_Form1, string filterFromForm3)
        {
            InitializeComponent();
            pctBox_ImageSpace.Image = imageFrom_Form1;                          // przesłanie do form2 obrazu z form1
            pctBox_ImageSpace.SizeMode = PictureBoxSizeMode.AutoSize;           // dopasowanie wymiaru obrazu do picture Boxa
            txtBox_SelectedFilter.Text = filterFromForm3;                       // przesłanie z form3 informacji o wybranym filtrze

            if(filterFromForm3=="Low-Pass" || filterFromForm3 == "High-Pass")   // jeśli wybrano któryś z tych fitrów
            {
                cmbBox_MaskSize.Enabled = true;                                 // to uaktywnij comboBox z wyborem maski
            }
        }

        private void imApply(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(pctBox_ImageSpace.Image);
            
            try
            {
                if (txtBox_SelectedFilter.Text == "Average")                    // jeśli wybrano filtr Average
                {
                    pctBox_ImageSpace.Image = Processing.imAverageFilter(copy); // to zatosuj go na obrazie
                }
                if (txtBox_SelectedFilter.Text == "Red")                        // jeśli wybrano filtr Red
                {
                    string filter = txtBox_SelectedFilter.Text;
                    pctBox_ImageSpace.Image = Processing.imSetColorFilter(copy, filter); // to zatosuj go na obrazie
                }
                if (txtBox_SelectedFilter.Text == "Green")                        // jeśli wybrano filtr Red
                {
                    string filter = txtBox_SelectedFilter.Text;
                    pctBox_ImageSpace.Image = Processing.imSetColorFilter(copy, filter); // to zatosuj go na obrazie
                }
                if (txtBox_SelectedFilter.Text == "Blue")                        // jeśli wybrano filtr Red
                {
                    string filter = txtBox_SelectedFilter.Text;
                    pctBox_ImageSpace.Image = Processing.imSetColorFilter(copy, filter); // to zatosuj go na obrazie
                }
            }
            catch
            {
                MessageBox.Show("A problem occured!");
            }
            
        }

        private void imSave(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();                   // presenting a new dialog to choose directory where image will be saved
            try
            {
                dialog.InitialDirectory = "C:\\";                           // początkowa ścieżka
                dialog.Title = "Save a new image";                          // nazwa okienka
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fname = dialog.FileName;                         // nazwa pliku
                    pctBox_ImageSpace.Image.Save(dialog.FileName, ImageFormat.Jpeg);    // zapisz (nazwa pliku, format)
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
    }
}
