using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_09";

            int altura;
            string sellitos = "*";

            Console.Write("Ingrese la altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            for (int i = 0; i < altura; i++) {
                Console.WriteLine("{0}", sellitos);
                sellitos = sellitos + "**";
            }

            System.Console.ReadKey();
        }
    }
}
