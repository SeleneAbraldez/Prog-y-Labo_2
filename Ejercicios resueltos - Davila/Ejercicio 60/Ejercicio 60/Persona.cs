using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_60
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string ID;

        public string Nombre
        {
            get 
            {
                return this.nombre;    
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Identificacion
        {
            get
            {
                return this.ID;
            }
        }


        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, string ID):this(nombre,apellido)
        {
            this.ID = ID;
        }
    }
}
