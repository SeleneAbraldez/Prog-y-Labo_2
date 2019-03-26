using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_67
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre 
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido 
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Mostrar()
        {
            return String.Format("{0} {1}", this.nombre, this.apellido);
        }
    }
}
