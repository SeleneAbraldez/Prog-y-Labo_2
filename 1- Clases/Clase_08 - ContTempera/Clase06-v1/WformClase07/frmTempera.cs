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

namespace WformClase07
{
    public partial class frmTempera : Form
    {
        public frmTempera()
        {
            InitializeComponent();

            //Inicializo el combo box, me figuraran todos los colores posibles
            foreach(ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
            {
                cmbColor.Items.Add(item);
            }
        }

        public frmTempera(Tempera parametro) : this()
        {
            
            txtCantidad.Text = parametro;
           txtMarca.Text = parametro;
            cmbColor.Text = parametro;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Tempera nuevaTempera = new Tempera((ConsoleColor)this.cmbColor.SelectedItem, txtMarca.Text, sbyte.Parse(txtCantidad.Text));
            this.miTempera = nuevaTempera;
            this.DialogResult = DialogResult.OK;

        }

        private Tempera miTempera;

        public Tempera myTempera
        {
            get
            {
                return miTempera;
            }
            set
            {
                miTempera = value;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {

        }
    }
}
