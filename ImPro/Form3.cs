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
    public partial class Form3 : Form
    {
        Image temp_copy;                    // zmienna globalna na przechowanie zdjęcia z Form1

        public Form3(System.Drawing.Image imageFromForm1)
        {
            InitializeComponent();
            temp_copy = imageFromForm1;     // przypisanie zdjęcia z Form1 do zmiennej globalnej
        }

        private void CancelAndLeave(object sender, EventArgs e)
        {
            this.Close();                   // jeśli wciśnięto Cancel, następuje zamknięcie formularza
        }

        public void DisplayFilterForm(object sender, EventArgs e)
        {
            if (rd_btn_LowPass.Checked==true ||
                rd_btn_HighPass.Checked==true ||
                rd_btn_Median.Checked==true ||
                rd_btn_Average.Checked==true)  // jeśli spełniono warunek wyboru 1 opcji
            {
                this.Close();                               // zamkyka się Formularz
                string selectedFilter = "No filter selected";
                if (rd_btn_LowPass.Checked == true) selectedFilter = rd_btn_LowPass.Text;
                if (rd_btn_HighPass.Checked == true) selectedFilter = rd_btn_HighPass.Text;
                if (rd_btn_Median.Checked == true) selectedFilter = rd_btn_Median.Text;
                if (rd_btn_Average.Checked == true) selectedFilter = rd_btn_Average.Text;
                Form2 filterForm = new Form2(temp_copy, selectedFilter);    // tworzy się i otwiera nowy z edycją do filtrów
                filterForm.Show();
            }
            else
            {
                MessageBox.Show("Select one filter type to proceed");
            }
        }
    }
}
