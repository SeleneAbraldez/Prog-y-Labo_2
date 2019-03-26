using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Jugador:Persona
    {
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        
        public int PartidosJugados { get => partidosJugados;}
        public float PromedioGoles {
            get
            {
                if (this.partidosJugados != 0)
                {
                    this.promedioGoles = this.totalGoles / (float)this.partidosJugados;
                }
                else
                {
                    this.promedioGoles = 0;
                }
                return this.promedioGoles;
            }
        }
        public int TotalGoles { get => totalGoles;}
        
        public Jugador(string nombre, int totalGoles, int totalPartidos) :base(nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }
        
        public string mostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("\n----------------------------------------------------------");
            datos.AppendFormat("\nNombre: {0}",this.Nombre);
            datos.AppendFormat("\nDNI: {0}", this.Dni);
            datos.AppendFormat("\nTotal Goles: {0}", this.TotalGoles);
            datos.AppendFormat("\nPartidos Jugados: {0}", this.PartidosJugados);
            datos.AppendFormat("\nPromedio Goles: {0}", this.PromedioGoles);
            datos.Append("\n----------------------------------------------------------");
            
            return datos.ToString(); 
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1.Dni == j2.Dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }


        
    }
}
