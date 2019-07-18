using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            do{
                Console.Write("\nIngrese el tamaño de la piramide: ");
                int tamanio;
                int i, j, z;

                if (int.TryParse(Console.ReadLine(), out tamanio))
                {
                    for (i = tamanio, z = 1; i > 0; i--, z += 2)
                    {
                        for (int g = i; g >= 0; g--)
                        {
                            Console.Write(" ");
                        }
                        for (j = 0; j < z; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un valor válido.");
                }

                Console.Write("Presione S para continuar.");
                continuar = Console.ReadKey().KeyChar;

            }while (continuar == 's' || continuar == 'S') ;

            Console.ReadKey();

        }
    }
}
