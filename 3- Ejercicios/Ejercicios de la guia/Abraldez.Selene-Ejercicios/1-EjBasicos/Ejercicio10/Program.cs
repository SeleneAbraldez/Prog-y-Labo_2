using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_10";

            int altura;

            Console.Write("Ingrese la altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            for (int i = 1; i <= altura; i++) {
                for (int j = 0; j < (altura - i); j++) {
                    Console.Write(" ");
                }
                for (int k = 0; k < (i * 2) - 1; k++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            System.Console.ReadKey();
        }
    }
}
