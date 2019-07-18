using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Clase_06;
using Clase_06;

namespace WindowsForm.PaletaYTemperas
{
    public partial class frmTempera : Form
    {

        private Tempera _miTempera;

        public Tempera myTempera
        {
            get
            {
                return _miTempera;
            }
            set { _miTempera = value; }
        }

        public frmTempera()
        {
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                cmbColor.Items.Add(color);
            }
        }

        private void button1_Click(object sender, EventArgs e)  //aceptar
        {
            Tempera nuevaTempera = new Tempera((ConsoleColor)this.cmbColor.SelectedItem, txtMarca.Text, sbyte.Parse(txtCant.Text));
            //Convert.ToSByte(txtCant.Text
            //MessageBox.Show(Tempera.Mostrar(nuevaTempera));
            this._miTempera = nuevaTempera;
            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    
        private void frmTempera_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
