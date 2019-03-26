using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximo;
            int acumulador1 = 0;
            int acumulador2 = 0;

            Console.Write("\nIngrese un número: ");
            if (int.TryParse(Console.ReadLine(), out maximo))
            {
                for (int numero = 2; numero < maximo; numero++)
                {
                    acumulador1 = 0;
                    for (int i = 0; i < numero; i++)
                    {
                        acumulador1 = acumulador1 + i;
                    }

                    acumulador2 = 0;
                    for (int i = numero + 1; acumulador2 < acumulador1; i++)
                    {
                        acumulador2 = acumulador2 + i;
                    }

                    if (acumulador1 == acumulador2)
                    {
                        Console.WriteLine("{0}", numero);
                    }

                }
                Console.ReadKey();
            }
        }
    }
}
