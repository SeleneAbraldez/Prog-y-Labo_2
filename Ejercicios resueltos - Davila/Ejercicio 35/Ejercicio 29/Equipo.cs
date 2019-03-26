using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        { 
            this.jugadores = new List<Jugador>();
            this.cantidadDeJugadores = 0;
            this.nombre = "";            
        }

        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;

            if(!(e.jugadores.Contains(j)) && e.jugadores.Count < e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                retorno = true;
            }

            return retorno;
        }

        public string mostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            for (int i = 0; i < this.jugadores.Count; i++)
            {
                datos.Append(this.jugadores[i].mostrarDatos());
            }
            
            return datos.ToString();
        }

    }
}
