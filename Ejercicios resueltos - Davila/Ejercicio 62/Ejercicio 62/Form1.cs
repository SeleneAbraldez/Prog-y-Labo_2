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
        Thread t;

        public Form1()
        {
            t = new Thread(AsignarHora);
            InitializeComponent();            
        }

        public void AsignarHora() 
        {
            while (true)
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
                Thread.Sleep(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}
