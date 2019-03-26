using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int numero = 2;
            int acumulador;

            while (contador <= 4)
            {
                acumulador = 0;
                for (int i = 1; i < numero; i++) {
                    if (numero % i == 0)
                    {
                        acumulador = acumulador + i;
                    }                
                }

                if (acumulador == numero) {
                    contador++;
                    Console.WriteLine("{0}", numero);                
                }

                numero++;
            }

        }
    }
}
