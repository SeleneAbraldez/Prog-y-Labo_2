using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_21;


namespace Ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Euro euro = new Euro();
            Dolar dolar = new Dolar();
            Pesos pesos = new Pesos();
            
            double aux;
            if (double.TryParse(txtEuro.Text, out aux))
            {
                euro = (Euro)aux;
                dolar = (Dolar)euro;
                pesos = (Pesos)dolar;
                txtEuroEuro.Text = Math.Round(aux,2).ToString();
                txtEuroDolar.Text = Math.Round(dolar.getValor(),2).ToString();
                txtEuroPesos.Text = Math.Round(pesos.getValor(),2).ToString();
            }
            else 
            {
                txtEuroDolar.Text = "ERROR";
                txtEuroEuro.Text = "ERROR";
                txtEuroPesos.Text = "ERROR";            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Euro euro = new Euro();
            Dolar dolar = new Dolar();
            Pesos pesos = new Pesos();

            double aux;
            if (double.TryParse(txtDolar.Text, out aux))
            {
                dolar = (Dolar)aux;
                euro = (Euro)dolar;
                pesos = (Pesos)dolar;
                txtDolarDolar.Text = Math.Round(aux).ToString();
                txtDolarEuro.Text = Math.Round(euro.getValor(),2).ToString();
                txtDolarPesos.Text = Math.Round(pesos.getValor(),2).ToString();
            }
            else
            {
                txtDolarDolar.Text = "ERROR";
                txtDolarEuro.Text = "ERROR";
                txtDolarPesos.Text = "ERROR";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pesos pesos = new Pesos();
            Euro euro = new Euro();
            Dolar dolar = new Dolar();
            

            double aux;
            if (double.TryParse(txtPesos.Text, out aux))
            {
                pesos = (Pesos)aux;                
                dolar = (Dolar)pesos;
                euro = (Euro)dolar;

                txtPesosPesos.Text = Math.Round(aux,2).ToString();
                txtPesosDolar.Text = Math.Round(dolar.getValor(),2).ToString();
                txtPesosEuro.Text = Math.Round(euro.getValor(),2).ToString();
            }
            else
            {
                txtPesosDolar.Text = "ERROR";
                txtPesosEuro.Text = "ERROR";
                txtPesosPesos.Text = "ERROR";
            }
        }
    }
}
