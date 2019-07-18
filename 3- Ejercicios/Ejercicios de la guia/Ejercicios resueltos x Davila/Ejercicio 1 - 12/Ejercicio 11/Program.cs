using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            float promedio;

            bool flag = false;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el {0} numero : ", i);
                while (int.TryParse(Console.ReadLine(), out numero) == false || Validacion.Validar(numero, -100, 100) == false)
                {
                    Console.Write("ERROR. Debe ingresar un numero valido. Reingrese: ");
                }

                if (flag != true)
                {
                    maximo = numero;
                    minimo = numero;
                    flag = true;
                }
                else if (numero < minimo) {
                    minimo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }

                acumulador = acumulador + numero;
            }

            promedio = acumulador / 10;
            Console.WriteLine("Minimo = {0}; Maximo = {1}; Promedio = {2}", minimo, maximo, promedio);

            Console.ReadKey();
        }
    }
}
