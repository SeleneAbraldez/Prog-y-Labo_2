using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e1 = new Equipo(2, "elequipo");
            Jugador j1 = new Jugador("Marquitos",5,2);
            Jugador j2 = new Jugador("Juan", 7, 16);
            Jugador j3 = new Jugador("José", 0, 3);

            if (e1 + j1 && e1 + j2)
            {
                Console.WriteLine(e1.mostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo cargar.");
            }

            

            Console.ReadKey();
        }
    }
}
