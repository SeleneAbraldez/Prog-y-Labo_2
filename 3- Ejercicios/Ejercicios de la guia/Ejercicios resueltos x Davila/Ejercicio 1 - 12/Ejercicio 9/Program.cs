using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la piramide: ");
            int tamanio;
            int i, j, z;

            if (int.TryParse(Console.ReadLine(), out tamanio))
            {
                for (i = tamanio, z = 1; i > 0; i--, z += 2)
                {
                    for (j = 0; j < z; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }



            Console.ReadKey();
        }
    }
}
