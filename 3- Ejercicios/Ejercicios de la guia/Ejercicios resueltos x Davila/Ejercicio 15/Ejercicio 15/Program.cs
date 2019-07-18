using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado;
            string operador;
            bool validacion;
            do
            {
                Console.WriteLine("\nIngrese el primer numero:");
                validacion = double.TryParse(Console.ReadLine(), out numero1);
            } while (validacion == false);

            Console.WriteLine("\nIngrese el operador:");
            operador = Console.ReadLine();

            do
            {
                Console.WriteLine("\nIngrese el segundo numero:");
                validacion = double.TryParse(Console.ReadLine(), out numero2);
            } while (validacion == false);
            
            resultado = Calculadora.Calcular(numero1,numero2,operador);
            Calculadora.Mostrar(resultado);

            Console.ReadKey();
        }
    }
}
