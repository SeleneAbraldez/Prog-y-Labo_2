using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase07
{
    public partial class frmPaleta : Form
    {
        public frmPaleta()
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            frmTempera frm = new frmTempera();
            frm.ShowDialog();
            
        }
    }
}
