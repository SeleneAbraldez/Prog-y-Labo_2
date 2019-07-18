using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_13;

namespace Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            string entrada = txtBinario.Text;
            double salida = Conversor.BinarioDecimal(entrada);

            txtResultadoBin.Text = salida.ToString();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double entrada;
            string salida;
            if (double.TryParse(txtDecimal.Text,out entrada)) 
            {
                salida = Conversor.DecimalBinario(entrada);
                txtResultadoDec.Text = salida;
            }

        }
    }
}
