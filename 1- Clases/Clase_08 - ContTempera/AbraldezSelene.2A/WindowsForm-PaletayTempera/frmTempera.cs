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
    public partial class frmTempera : Form
    {
        private Tempera _miTempera;
        public Tempera miTemperaFrm
        {
            get {
                return _miTempera;
            }
            set {
                _miTempera = value;
            }
        }

        public frmTempera()
        {
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                cmbColor.Items.Add(color);
            }
            this.cmbColor.SelectedItem = ConsoleColor.DarkMagenta;
        }

        public frmTempera(Tempera parametro) : this()
        {
            string marc = parametro;
            sbyte cant = parametro;
            ConsoleColor col = parametro;

            txtBCantidad.Text = cant.ToString();  //necesarias las sobrecargas para cada tipo
            txtBMarca.Text = marc;
            cmbColor.Text = col.ToString();

            txtBCantidad.Enabled = false;
            cmbColor.Enabled = false;
            txtBMarca.Enabled = false;
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Tempera nuevaTempera = new Tempera((ConsoleColor)this.cmbColor.SelectedItem, txtBMarca.Text, sbyte.Parse(txtBCantidad.Text));
            this._miTempera = nuevaTempera;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
