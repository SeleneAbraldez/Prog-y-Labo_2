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
    public partial class frmTestDelegados : Form
    {
        public delegate void Delegado(string a);
        public event Delegado actualizado;
        public event Delegado fotoActualizada;

        private string ruta;

        public frmTestDelegados()
        {
            InitializeComponent();
            ruta = "";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                this.actualizado(textBox1.Text);
                this.fotoActualizada(ruta);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar 'Mostrar' primero");
            }
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ruta = openFileDialog1.FileName;
        }
    }
}
