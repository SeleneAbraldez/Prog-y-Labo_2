using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_68
{
    public partial class frmPrincipal : Form
    {

        frmTestDelegados formTestDelegados;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTestDelegados = new frmTestDelegados();
            formTestDelegados.Owner = this;
            formTestDelegados.StartPosition = FormStartPosition.CenterScreen;
            formTestDelegados.Show();            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos formDatos = new FrmDatos();
            formDatos.Owner = this;
            formDatos.Show();
            try
            {
                formTestDelegados.actualizado += formDatos.ActualizarNombre;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar 'TestDelegados' primero");
            }
                
        }
    }
}
