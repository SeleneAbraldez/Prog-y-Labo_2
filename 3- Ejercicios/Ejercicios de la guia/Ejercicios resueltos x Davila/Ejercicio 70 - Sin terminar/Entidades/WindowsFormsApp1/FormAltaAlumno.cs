using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class frmAltaAlumno : Form
    {
        public delegate void AlumnoEventHandler(Entidades.Alumno alumno);
        public event AlumnoEventHandler alumnoCreado;

        public frmAltaAlumno()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void txtFoto_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();            
            txtFoto.Text = openFileDialog1.FileName;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno a = new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), txtFoto.Text);
                frmDatosAlumno frmDatos = new frmDatosAlumno();
                alumnoCreado += frmDatos.ActualizarAlumno;
                this.alumnoCreado(a);
                frmDatos.Show();                
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe llenar los casilleros.");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
