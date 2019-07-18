using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Clase05_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta1 = new Tinta();
            Tinta tinta2 = new Tinta(ConsoleColor.DarkMagenta);
            Tinta tinta3 = new Tinta(ConsoleColor.DarkGreen, eTipoTinta.ConBrillito);

            Console.WriteLine(Tinta.Mostrar(tinta1));
            Console.WriteLine(Tinta.Mostrar(tinta2));
            Console.WriteLine(Tinta.Mostrar(tinta3));

            Tinta tinta4 = new Tinta();
            Tinta tinta5 = tinta4;

            if (tinta4 == tinta1){   //tinta4 == tinta5
                Console.WriteLine("v- Son iguales.");
            }else{
                Console.WriteLine("x- No iguales.");
            }

            if (tinta4 == ConsoleColor.Black) {  
                Console.WriteLine("v- Los colores son iguales.");
            }
            else
            {
                Console.WriteLine("x- No iguales.");
            }

            //

            Pluma pluma1 = new Pluma("Bic", tinta1, 20);

            Console.WriteLine();

            if (pluma1 == tinta1)
            {
                Console.WriteLine("v- Las tintas son iguales.");
            }
            else
            {
                Console.WriteLine("x- No iguales.");
            }

            //mostrar



            Console.ReadKey();
        }
    }
}
