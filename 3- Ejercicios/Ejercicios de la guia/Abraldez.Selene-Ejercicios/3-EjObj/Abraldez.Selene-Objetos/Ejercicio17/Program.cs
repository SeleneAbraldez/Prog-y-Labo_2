using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_17";

            string dibujoAzul;
            string dibujoRojo;

            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            boligrafoAzul.Pintar(55, out dibujoAzul);
            Console.WriteLine(dibujoAzul);
            boligrafoAzul.Pintar(55, out dibujoAzul); 
            Console.WriteLine(dibujoAzul); //no hay sifucuente por 51+51>100

            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
            boligrafoRojo.Pintar(55, out dibujoRojo);            
            Console.WriteLine(dibujoRojo); //no hay suficiente porque 51>50
            boligrafoRojo.Pintar(50, out dibujoRojo);
            Console.WriteLine(dibujoRojo);
            boligrafoRojo.Recargar();
            boligrafoRojo.Pintar(55, out dibujoRojo);
            Console.WriteLine(dibujoRojo);  //luego de la recarga de la lapicera, se puede

            Console.ReadKey();
        }
    }
}
