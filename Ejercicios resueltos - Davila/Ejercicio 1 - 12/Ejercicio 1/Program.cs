using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float acumulador = 0;
            int numero;
            int maximo;
            int minimo;
            float promedio;

            Console.Write("\nIngrese un número: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                minimo = numero;
                maximo = numero;
                acumulador = acumulador + numero;

                for (int i = 1; i < 5; i++)
                {
                    Console.Write("\nIngrese un número: ");
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                        else if (numero > maximo)
                        {
                            maximo = numero;
                        }

                        acumulador = acumulador + numero;
                    }
                }

                promedio = acumulador / 5;
                Console.WriteLine("Maximo = {0}, Minimo = {1}, Promedio = {2}", maximo, minimo, promedio);
            }
            Console.ReadKey();
        }
    }
}
