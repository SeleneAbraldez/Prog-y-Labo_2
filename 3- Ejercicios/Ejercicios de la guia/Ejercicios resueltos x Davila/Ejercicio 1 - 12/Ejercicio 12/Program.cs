using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int number;
            int acumulador = 0;
            Console.Write("Ingrese el primer numero: ");
            int.TryParse(Console.ReadLine(),out number);
            acumulador = acumulador + number;
            do {
                Console.Write("\nIngrese el siguiente numero a sumar: ");
                int.TryParse(Console.ReadLine(), out number);
                acumulador = acumulador + number;
                Console.Write("\nContinua? S/N: ");
                respuesta = Console.ReadKey().KeyChar;
            } while (ValidarRespuesta.ValidaS_N(respuesta));
            Console.WriteLine("\n\nTotal: {0}", acumulador);
            Console.ReadKey();

        }
    }
}
