using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class frmDatosAlumno : WindowsFormsApp1.frmAltaAlumno
    {
        public frmDatosAlumno()
        {
            InitializeComponent();
        }

        public void ActualizarAlumno(Entidades.Alumno alumno)
        {
            pictureBox1.ImageLocation = alumno.RutaDeLaFoto;
        }
    }
}
