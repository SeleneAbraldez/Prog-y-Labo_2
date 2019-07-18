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
       

            p += parametro.myTempera;
            //Validar para cuando llegue a 5 no puede ingresar mas
            
            refrescarColores(parametro);
 
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int indice = this.listBox1.SelectedIndex;

            //MessageBox.Show(Tempera.Mostrar(this.p.myTemperas[indice]));
            btnMenos.Enabled = true;
            if (indice > -1)
            {
               
                frmTempera borrarTempera = new frmTempera(this.p.myTemperas[indice]);
                borrarTempera.ShowDialog();


                if (borrarTempera.DialogResult == DialogResult.OK)
                {
                    this.p -= borrarTempera.myTempera;
                    refrescarColores(borrarTempera);
                }

            }
            else
            {
                btnMenos.Enabled = false;
            }



            //Refrescar lista


        }

        private void refrescarColores(frmTempera parametro)
        {
            int i = 0;
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

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Zahira la loca
            //Cuando se selecciona, se tiene que modificar

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Tuviera la chance de agregar p
        //TextBox o comboBox 
    }
}
