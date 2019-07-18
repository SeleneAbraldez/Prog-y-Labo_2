using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_11";

            int num = 0;
            float acum = 0;
            int numMax = 0;
            int numMin = 0;
            float promedio;
            int i;

            for (i = 0; i < 10; i++) {
                Console.Write("Ingrese un numero ({0}): ", (i+1));
                num = int.Parse(Console.ReadLine());
                while( Validacion.Validar(num, -100, 100) == false) {
                   Console.Write("ERROR. ¡Reingresar número ({0})! Debe estar entre -100 y 100: ", (i+1));
                    num = int.Parse(Console.ReadLine());
                }

                if (i == 0) {
                    numMax = num;
                    numMin = num;
                } else {
                    if (num > numMax) {
                        numMax = num;
                    }
                    if (num < numMin) {
                        numMin = num;
                    }
                }
                acum = acum + num;
            }

            promedio = (float)(acum / i);

            System.Console.WriteLine("\n·El numero maximo es: {0}", numMax);
            System.Console.WriteLine("·El numero minimo es: {0}", numMin);
            System.Console.WriteLine("·El promedio es: {0}", promedio);
            System.Console.ReadKey();

            Console.Read();
        }
    }
}
