using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Persona
    {
        private long dni;
        private string nombre;

        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni;            
        }

        public Persona (string nombre)
        {
            this.nombre = nombre;
        }

        public string mostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("\nNombre: {0}", this.Nombre);
            datos.AppendFormat("\nDNI: {0}", this.Dni);

            return datos.ToString();
        }

    }
}
