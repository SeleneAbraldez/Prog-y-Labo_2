using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest
{
    public class Manejadora
    {
        public static void Manejador(object ev, EventArgs e)
        {
            MessageBox.Show("Estoy en la clase manejadora estatica");
            
        }

        public void ManejadorDos(object ev, EventArgs e)
        {
            MessageBox.Show("Estoy en la clase manejadora no estatica");

            if(ev is Button)
            {
                MessageBox.Show("El objeto es un boton");
            }
            else if(ev is Label)
            {
                MessageBox.Show("El objeto es un label");
            }
            else if(ev is TextBox)
            {
                MessageBox.Show("El objeto es un textbox");
            }
        }
        
        public static void Sumar(int a, int b)
        {
            int resultado = a + b;
            MessageBox.Show("Resultado: " + resultado);
        }

        public void Restar(int a, int b)
        {
            int resultado = a - b;
            MessageBox.Show("Resultado: " + resultado);
        }

        public void Multiplicar(int a, int b)
        {
            int resultado = a * b;
            MessageBox.Show("Resultado: " + resultado);
        }

        public void OtraSuma(MiDelegado miDelegado, int a, int b)
        {
            miDelegado.Invoke(a, b);
        }

    }
}
