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

namespace WindowsForm_PaletayTempera
{
    public partial class frmPaleta : Form
    {
        Paleta nuevaInstPaleta;

        public frmPaleta()
        {
            InitializeComponent();
            this.nuevaInstPaleta = 5;
            btnMenos.Enabled = false;
        }

        public frmPaleta(int cantMax) : this()
        {
            this.nuevaInstPaleta = cantMax;
            this.Text = "Paleta (Temperas Maximas: " + cantMax + ")";
        }

        private void frmPaleta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            frmTempera nuevaTempera = new frmTempera();
            nuevaTempera.ShowDialog();

            if (nuevaTempera.DialogResult == DialogResult.OK)
            {
                this.nuevaInstPaleta += nuevaTempera.miTemperaFrm;
                refrescarColores(nuevaTempera);
            }
            btnMenos.Enabled = false;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int indice = this.listBTemperas.SelectedIndex;

            frmTempera menosTempera = new frmTempera(this.nuevaInstPaleta.misTemperas[indice], false);
            menosTempera.ShowDialog();

            if (menosTempera.DialogResult == DialogResult.OK)
            {
                this.nuevaInstPaleta -= menosTempera.miTemperaFrm;
                refrescarColores(menosTempera);
            }
            btnMenos.Enabled = false;
        }

        private void listBTemperas_MouseClick(object sender, MouseEventArgs e)
        {
            int indice = this.listBTemperas.SelectedIndex;
            if (indice != -1)
            {
                btnMenos.Enabled = true;
            }
        }

        private void listBTemperas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = this.listBTemperas.SelectedIndex;
            if (indice != -1)
            {
                frmTempera modificarTempera = new frmTempera(this.nuevaInstPaleta.misTemperas[indice], true);
                modificarTempera.ShowDialog();
                if (modificarTempera.DialogResult == DialogResult.OK)
                {
                    this.nuevaInstPaleta.misTemperas[indice] = modificarTempera.miTemperaFrm;
                    refrescarColores(modificarTempera);
                }
            }
        }

        
        private void refrescarColores(frmTempera parametro)
        {
            listBTemperas.Items.Clear();
            foreach (Tempera t in nuevaInstPaleta.misTemperas)
            {
                if (parametro.DialogResult == DialogResult.OK && t != null)
                {
                    listBTemperas.Items.Add(Tempera.Mostrar(t));
                }
            }
        }

       
    }
}
