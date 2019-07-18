using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //el objeto puede estar definido en cualquier lado(ejecutar en cualquier lugar)
            // **OBJETO******EVENTO
            //*****|***********|***
            //*****V***********V***
            //this.lblEtiqueta.Click += new EventHandler(Manejadora.Manejador);
            //Llamamos a la clase Manejadora, para que se ejecute su metodo

            Manejadora aux = new Manejadora();
            this.btnBoton.Click += new EventHandler(aux.ManejadorDos);
            this.lblEtiqueta.Click += new EventHandler(aux.ManejadorDos);
            this.txtCuadroTexto.Click += new EventHandler(aux.ManejadorDos);


        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del boton");
            this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click);//Se va a estar agregando un nuevo metodo
            this.txtCuadroTexto.Click += new System.EventHandler(this.txtCuadroTexto_Click);
            //agrega de manera dinamica a un manejador de eventos
        }

        //Sender -> envia, EventArgs -> que tecla fue pulsada
        private void txtCuadroTexto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblEtiqueta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del Label");
            this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click);
        }

        private void txtCuadroTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del textBox");
        }
    }
}
