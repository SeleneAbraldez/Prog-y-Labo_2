using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06;

namespace WindowsForm.PaletaYTemperas
{
    public partial class frmPaleta : Form
    {
        Paleta NuevaInsPaleta;

        public frmPaleta()
        {
            InitializeComponent();
            this.NuevaInsPaleta = 5; 
        }

        private void frmPaleta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera nuevaTempera = new frmTempera();
            nuevaTempera.ShowDialog();
            NuevaInsPaleta += nuevaTempera.myTempera;

            foreach (Tempera t in NuevaInsPaleta._MisTemperas)
            {
                if (/*nuevaTempera.DialogResult == DialogResult.OK &&*/ t != null)
                {
                    listBox1.Items.Add(Tempera.Mostrar(t));
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

        }
    }
}
