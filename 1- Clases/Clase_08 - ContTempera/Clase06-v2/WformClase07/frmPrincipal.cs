using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WformClase07
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;//nuestro formulario principal tenga la capacdad de contener a otros formularios
            this.WindowState = FormWindowState.Maximized;
         
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaleta nuevaPaleta = new frmPaleta();
            nuevaPaleta.MdiParent = this;
            nuevaPaleta.StartPosition = FormStartPosition.CenterScreen;
            nuevaPaleta.Show();
            //Formulario contenedor de otro formiulario
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmPrincipal_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, true));

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            //Poner aca la cantidad de p 
        }
    }
}
