using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int anio = 0;
            Console.Write("\nIngrese un año: ");
            if(int.TryParse(Console.ReadLine(), out anio))
            {
                if (anio % 4 == 0)
                {
                    if (!(anio % 100 == 0) || anio % 400 == 0)
                    {
                        Console.WriteLine("Es biciesto.");
                    }
                    else
                    {
                        Console.WriteLine("NO es biciesto.");
                    }
                }
                else
                {
                    Console.WriteLine("NO es biciesto.");
                }
            }
            

            Console.ReadKey();
        }
    }
}
