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
    
 
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string valor)
        {
            label1.Text = valor;
        }

        public void ActualizarFoto(string valor)
        {
            pictureBox1.ImageLocation = valor;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
