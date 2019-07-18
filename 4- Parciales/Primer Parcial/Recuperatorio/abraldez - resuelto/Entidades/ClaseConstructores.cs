using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class ClaseConstructores
    {
        private int escritura;
        private int lectura;

        public int Escritura
        {
            set {
                MessageBox.Show("4- Propiedad de solo escritura");
                escritura = this.Lectura;
            }
        }

        public int Lectura
        {
            get {
                MessageBox.Show("5- Propiedad de solo lectura");
                return MetodoDeInstancia();
            }
        }


        static ClaseConstructores()
        {
            MessageBox.Show("1- Constructor Estatico");
        }

        private ClaseConstructores(string a, string b)
        {
            MessageBox.Show("2- Constructor privado con dos parametros");
        }

        public ClaseConstructores() : this("a", "b")
        {
            MessageBox.Show("3- Constructor default publico");
            this.Escritura = 3;

        }

        public int MetodoDeInstancia()
        {
            MessageBox.Show("6- Metodo de instancia");
            return MetodoDeClase();

        }

        public static int MetodoDeClase()
        {
            MessageBox.Show("7- Metodo de clase");
            return 1;
        }

    }
}
