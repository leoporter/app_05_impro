using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImPro
{
    public partial class Form4 : Form
    {
        public Form4(System.Drawing.Image imageFromForm1)
        {
            InitializeComponent();
            pictureBox1.Image = imageFromForm1;
            txtBox_R1.Text = "0.299";
            txtBox_G1.Text = "0.587";
            txtBox_B1.Text = "0.114";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click_Apply(object sender, EventArgs e)
        {
            try
            {
                decimal R2 = Convert.ToDecimal(txtBox_R2.Text);
                decimal G2 = Convert.ToDecimal(txtBox_G2.Text);
                decimal B2 = Convert.ToDecimal(txtBox_R2.Text);
                pictureBox2.Image = Processing2.imSetRGBWeights((Bitmap)pictureBox1.Image, R2, G2, B2);
            }
            catch
            {
                MessageBox.Show("A problem occured!");
            }
        }
    }
}
