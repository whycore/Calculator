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
    public partial class FrmCalculator : Form
    {
        public delegate void CalculatorEventHandler(int index, float a, float b);
        public event CalculatorEventHandler OnPerhitungan;

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            float NilaiA = float.Parse(txtNilaiA.Text);
            float NilaiB = float.Parse(txtNilaiB.Text);

            if (cmbOperasi.SelectedIndex == 0)
            {
                OnPerhitungan(0, NilaiA, NilaiB);
            }
            else if (cmbOperasi.SelectedIndex == 1)
            {
                OnPerhitungan(1, NilaiA, NilaiB);
            }
            else if (cmbOperasi.SelectedIndex == 2)
            {
                OnPerhitungan(2, NilaiA, NilaiB);
            }
            else
            {
                OnPerhitungan(3, NilaiA, NilaiB);
            }
        }
    }
}