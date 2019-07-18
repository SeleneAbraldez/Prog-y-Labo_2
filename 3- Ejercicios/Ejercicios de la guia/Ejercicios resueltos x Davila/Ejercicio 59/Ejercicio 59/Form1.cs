using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_59
{
    public partial class Form1 : Form
    {
        Conexion c;

        public Form1()
        {
            InitializeComponent();
            c = new Conexion();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (RegistrarButton.Checked)
            {
                if (c.RegisteredPerson(textBoxNombre.Text) == 0)
                {
                    richTextBox1.Text = c.Insert(textBoxNombre.Text);
                }
                else
                {
                    richTextBox1.Text = "ERROR. No puede ingresar un nombre que ya existe.";
                }
            }
            else if (EliminarButton.Checked)
            {
                if (c.RegisteredPerson(textBoxNombre.Text) > 0)
                {
                    richTextBox1.Text = c.Eliminar(textBoxNombre.Text);
                }
                else
                {
                    richTextBox1.Text = "ERROR. No existe ese campo.";
                }
            }
            else
            {
                int auxTextBoxNombre = c.RegisteredPerson(textBoxNombre.Text);
                int auxTextBoxEntrada = c.RegisteredPerson(textBox1.Text);
                if (auxTextBoxNombre > 0 && auxTextBoxEntrada == 0)
                {
                    richTextBox1.Text = c.Modificar(textBoxNombre.Text,textBox1.Text);
                }
                else if(auxTextBoxNombre == 0)
                {
                    richTextBox1.Text = "ERROR. No existe el campo a reemplazar.";
                }
                else
                {
                    richTextBox1.Text = "ERROR. No puede ingresar un nombre que ya existe.";
                }
            }
        }

        private void RegistrarButton_CheckedChanged(object sender, EventArgs e)
        {
            button.Text = "Registrar";
            button.BackColor = Color.LightGray;
            textBox1.Enabled = false;
        }

        private void EliminarButton_CheckedChanged(object sender, EventArgs e)
        {
            button.Text = "Eliminar";
            button.BackColor = Color.Red;
            textBox1.Enabled = false;
        }

        private void ModificarButton_CheckedChanged(object sender, EventArgs e)
        {
            button.Text = "Modificar";
            button.BackColor = Color.LightGray;
            textBox1.Enabled = true;
        }
    }
}
