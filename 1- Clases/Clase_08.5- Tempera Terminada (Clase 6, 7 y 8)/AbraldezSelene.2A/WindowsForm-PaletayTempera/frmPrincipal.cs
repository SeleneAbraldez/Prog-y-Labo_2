using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_PaletayTempera
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //nuestro formulario principal tenga la capacdad de contener a otros formularios
            //this.WindowState = FormWindowState.Maximized;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantMax = Int32.Parse(toolStripTextBox1.Text);

            frmPaleta nuevaPaleta = new frmPaleta(cantMax);

            nuevaPaleta.MdiParent = this; //este principal es el padre
            nuevaPaleta.StartPosition = FormStartPosition.CenterScreen;
            nuevaPaleta.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
