using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_15";

            int num1;
            int num2;
            char opcion;
            double resultado;

            Console.WriteLine("--Calculadora--\n");
            Console.Write("Ingrese numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Que desea realizar con estos numeros?");
            Console.Write("'+' para sumar, '-' restar, '*' multiplicar y '/' para dividir: ");
            opcion = Console.ReadKey().KeyChar;

            resultado = Calculadora.Calcular(num1, num2, opcion);
            Console.WriteLine("\nResultado : {0}", resultado);

            Console.ReadKey();
        }
    }
}
