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
        }

        private void frmPaleta_Load(object sender, EventArgs e)
        {

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            frmTempera nuevaTempera = new frmTempera();
            nuevaTempera.ShowDialog();

            nuevaInstPaleta += nuevaTempera.miTemperaFrm;

            /*listBTemperas.Items.Clear();
            foreach (Tempera t in nuevaInstPaleta.misTemperas)
            {
                if (nuevaTempera.DialogResult == DialogResult.OK && t != null)
                {
                    listBTemperas.Items.Add(Tempera.Mostrar(t));
                }
            }
            */
            if (nuevaTempera.DialogResult == DialogResult.OK)
            {
                refrescarColores(nuevaTempera);
            }
            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int indice = this.listBTemperas.SelectedIndex;

            frmTempera menosTempera = new frmTempera(this.nuevaInstPaleta.misTemperas[indice]);
            menosTempera.ShowDialog();

            if (menosTempera.DialogResult == DialogResult.OK)
            {
                this.nuevaInstPaleta -= menosTempera.miTemperaFrm;
                refrescarColores(menosTempera);
            }
        }






        private void refrescarColores(frmTempera parametro)
        {
            listBTemperas.Items.Clear();
            foreach (Tempera t in nuevaInstPaleta.misTemperas)
            {
                if (parametro.DialogResult == DialogResult.OK && t!=null)
                {
                    listBTemperas.Items.Add(Tempera.Mostrar(t));
                }
            }
        }


    }
}
