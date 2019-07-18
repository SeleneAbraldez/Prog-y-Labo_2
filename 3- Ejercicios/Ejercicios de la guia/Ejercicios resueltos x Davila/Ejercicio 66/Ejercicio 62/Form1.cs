using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio_62
{
    public partial class Form1 : Form
    {
        Temporizador t;

        public Form1()
        {
            InitializeComponent();            
        }

        public void AsignarHora() 
        {
            if (this.lblHora.InvokeRequired)
            {
                this.lblHora.BeginInvoke(
                    (MethodInvoker)delegate()
                {
                    lblHora.Text = DateTime.Now.ToString();
                }
                );
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            t = new Temporizador(1000);
            t.EventoTiempo += t_EventoTiempo;
            t.Activo = true;
        }

        void t_EventoTiempo()
        {
            AsignarHora();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Activo = false;
        }
    }
}
