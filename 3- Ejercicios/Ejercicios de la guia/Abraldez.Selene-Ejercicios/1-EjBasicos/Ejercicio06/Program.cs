using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_06";

            int añoPrincipio;
            int añoFinal;

            Console.Write("Ingrese comienzo de rango: ");
            añoPrincipio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese final de rango: ");
            añoFinal = int.Parse(Console.ReadLine());

            Console.Write("Años biciestos en rango de {0} - {1}: ", añoPrincipio, añoFinal);

            while (añoPrincipio < añoFinal) {
                añoPrincipio++;
                if ((añoPrincipio % 4 == 0 && añoPrincipio % 100 != 0) || (añoPrincipio % 400 == 0)) {
                     Console.Write("{0} , ", añoPrincipio);
                }
            }
        
            System.Console.ReadKey();
        }
    }
}
