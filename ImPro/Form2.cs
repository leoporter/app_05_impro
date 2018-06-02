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
            pctBox_ImageSpace.Image = imageFrom_Form1;
            txtBox_SelectedFilter.Text = filterFromForm3;
            if(filterFromForm3=="Low-Pass" || filterFromForm3 == "High-Pass")
            {
                cmbBox_MaskSize.Enabled = true;
            }
        }

        private void imApply(object sender, EventArgs e)
        {

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
