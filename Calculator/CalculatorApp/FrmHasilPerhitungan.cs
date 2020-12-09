using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FrmHasilPerhitungan : Form
    {
        public FrmHasilPerhitungan()
        {
            InitializeComponent();
        }

        private void FrmHasil_OnPerhitungan(int index, float a, float b)
        {
            var cal = new Calculator();

            if (index == 0)
            {
                lstHasil.Items.Add(string.Format("Hasil Penjumlahan dari {0} + {1} = {2}", a, b, cal.Penjumlahan(a, b)));
            }
            else if (index == 1)
            {
                lstHasil.Items.Add(string.Format("Hasil Pengurangan dari {0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            }
            else if (index == 2)
            {
                lstHasil.Items.Add(string.Format("Hasil Perkalian dari {0} * {1} = {2}", a, b, cal.Perkalian(a, b)));
            }
            else
            {
                lstHasil.Items.Add(string.Format("Hasil Pembagian dari {0} / {1} = {2}", a, b, cal.Pembagian(a, b)));
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmCalculator myForm = new FrmCalculator();

            myForm.OnPerhitungan += FrmHasil_OnPerhitungan;
            myForm.ShowDialog();
        }
    }
}