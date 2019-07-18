using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nameSpaceClase_04;

namespace Clase04.windForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Titulo";
            this.BackColor = Color.DarkViolet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cosa obj = new Cosa();
            MessageBox.Show(obj.Mostrar());
            this.button1.Text = "Volver";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Cosa obj = new Cosa();
            this.button1.Text = "fecha";
        }
    }
}
