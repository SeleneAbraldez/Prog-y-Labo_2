using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_12";

            int numero = 0;
            char c;
            do {
                Console.Write("Numero a sumar: ");
                numero = numero + int.Parse(Console.ReadLine());

                Console.Write("Continuar? ('S' para continuar, cualquier otra tecla para salir): ");
                c = char.Parse(Console.ReadLine()); //parsear a char

            } while (ValidarRespuesta.ValidaS_N(c) == true);
            Console.WriteLine("Suma: {0}", numero);
            Console.Read();
        }
    }
}
