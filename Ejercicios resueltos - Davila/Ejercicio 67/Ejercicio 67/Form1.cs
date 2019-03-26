using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_67
{
    public partial class Form1 : Form
    {
        private Persona persona;
        private event DelegadoString delegadoString;

        public Form1()
        {
            InitializeComponent();
        }

        public static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            delegadoString += NotificarCambio;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (persona == null)
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text);
                button.Text = "Actualizar";
                delegadoString("Se ha creado la persona " + persona.Mostrar());
            }
            else
            {
                if (persona.Nombre != txtNombre.Text)
                {
                    persona.Nombre = txtNombre.Text;
                    delegadoString("Se ha actualizado el nombre a " + persona.Nombre);
                }

                if (persona.Apellido != txtApellido.Text)
                {
                    persona.Apellido = txtApellido.Text;
                    delegadoString("Se ha actualizado el apellido a " + persona.Apellido);
                }

                delegadoString(persona.Mostrar() + " se encuentra actualizado");
            }
        }


    }
}
