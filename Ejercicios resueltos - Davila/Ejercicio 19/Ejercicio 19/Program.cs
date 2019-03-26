using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafo2 = new Boligrafo(ConsoleColor.Red, 50);

            if (boligrafo1.Pintar(50))
            {
                Console.Write("Escribo en Azul\n");
            }


            if (boligrafo2.Pintar(50))
            {
                Console.Write("Escribo en Rojo\n");
            }


            if (boligrafo1.Pintar(50))
            {
                Console.Write("Escribo en Azul\n");
            }

            boligrafo2.Recargar();
            if (boligrafo2.Pintar(50))
            {
                Console.Write("Escribo en Rojo\n");
            }

            if (boligrafo1.Pintar(50)) //Sin tinta
            {
                Console.Write("Escribo en Azul\n");
            }

            Console.ReadKey();

        }
        
    }
}
