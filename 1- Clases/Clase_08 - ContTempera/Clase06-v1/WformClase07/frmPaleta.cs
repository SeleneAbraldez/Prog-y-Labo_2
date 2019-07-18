using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase06;

namespace WformClase07
{
    public partial class frmPaleta : Form
    {
        Paleta p ; //Defino paleta

        public frmPaleta()
        {
            InitializeComponent();
            this.p = 5;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            frmTempera parametro = new frmTempera();
            parametro.ShowDialog();
            int i = 0;

            p += parametro.myTempera;
            //Validar para cuando llegue a 5 no puede ingresar mas
            listBox1.Items.Clear();
            foreach (Tempera c in p.myTemperas)
                {

                if (parametro.DialogResult == DialogResult.OK && c != null)
                    {
                        listBox1.Items.Add(Tempera.Mostrar(c));
                        i++;
                    }

            }
 
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int indice = this.listBox1.SelectedIndex;

            //MessageBox.Show(Tempera.Mostrar(this.p.myTemperas[indice]));
            frmTempera borrarTempera = new frmTempera(this.p.myTemperas[indice]);
            borrarTempera.ShowDialog();
            
        }

        private void frmPaleta_Load(object sender, EventArgs e)
        {

        }
    }
}
