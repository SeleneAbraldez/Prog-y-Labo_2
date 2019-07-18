using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";

            int num;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            while (num < 0){
                Console.Write("ERROR. ¡Reingresar número! Debe ser mayor que 0: ");
                num = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("·El cuadrado del numero es: {0}", (long)Math.Pow(num, 2));
            System.Console.WriteLine("·El cubo del numero es: {0}", (long)Math.Pow(num, 3));
            System.Console.ReadKey();
        }
    }
}
