using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class DirectorTecnico:Persona
    {
        DateTime fechaNacimiento;

        public DirectorTecnico(string nombre) :base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) :this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }


        public string mostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("\n----------------------------------------------------------");
            datos.AppendFormat("\nNombre: {0}", this.Nombre);
            datos.AppendFormat("\nDNI: {0}", this.Dni);
            datos.AppendFormat("\nFecha Nacimiento: {0}", this.fechaNacimiento);
            datos.Append("\n----------------------------------------------------------");

            return datos.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            bool retorno = false;
            if (dt1.Dni == dt2.Dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
