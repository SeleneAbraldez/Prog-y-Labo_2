using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            double resultadoCuadrado;
            double resultadoCubo;
            bool parse = false;
            do{
                Console.Write("Ingrese un numero: ");
                parse = int.TryParse(Console.ReadLine(), out numero);          
            }while(parse == false || numero <= 0);

            resultadoCuadrado = Math.Pow(numero,2);
            resultadoCubo = Math.Pow(numero, 3);

            Console.WriteLine("{0} al cuadrado = {1}", numero, resultadoCuadrado);
            Console.WriteLine("{0} al cubo = {1}", numero, resultadoCubo);

            Console.ReadKey();
        }
    }
}
