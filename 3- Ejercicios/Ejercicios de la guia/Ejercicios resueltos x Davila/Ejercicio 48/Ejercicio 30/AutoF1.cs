using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                caballosDeFuerza = value;
            }
        }

        public AutoF1(short numero, string escuderia) : this(numero, escuderia,0)
        {
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public string mostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("\nCaballos de Fuerza: {0}", this.CaballosDeFuerza);

            return datos.ToString();
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.CaballosDeFuerza == a2.CaballosDeFuerza)
            {
                retorno = true;
            }

            return retorno;
        }

    }
}
