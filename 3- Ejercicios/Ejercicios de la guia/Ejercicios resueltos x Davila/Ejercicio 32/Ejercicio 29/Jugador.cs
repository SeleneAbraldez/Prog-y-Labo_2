using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
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

        private Jugador()
        {
            this.Dni = 0;
            this.Nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(string nombre) :this()
        {
            this.Nombre = nombre;
        }

        public Jugador(string nombre, int totalGoles, int totalPartidos) :this(nombre)
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
