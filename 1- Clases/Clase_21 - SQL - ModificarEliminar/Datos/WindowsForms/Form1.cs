using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private List<Persona> _personas;
        private DataTable _tabla;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AccesoDatos ad = new AccesoDatos();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _personas = ad.TraerTodos();
            _tabla = ad.TraerTablaPersonas();

            dataGridView1.DataSource = this._tabla;
        }
    }
}
