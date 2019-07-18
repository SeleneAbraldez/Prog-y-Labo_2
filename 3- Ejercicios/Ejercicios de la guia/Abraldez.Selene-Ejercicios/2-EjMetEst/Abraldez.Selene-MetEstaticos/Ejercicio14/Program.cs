using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_14";

            int opcion;
            double resultado = 0;

            Console.WriteLine("--Areas--");
            Console.WriteLine("1- Cuadrado \n2- Triangulo \n3- Circulo");
            Console.Write("Que area desea calcular?: ");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion){
            case 1:
                    Console.WriteLine("Ingrese lado del Cuadrado");
                    resultado = CalculoDeArea.CalcularCuadrado(int.Parse(Console.ReadLine()));
                    break;
            case 2:
                    int baseT;
                    Console.WriteLine("Ingrese base del Triangulo");
                    baseT = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese altura del Triangulo");
                    resultado = CalculoDeArea.CalcularTriangulo(baseT ,int.Parse(Console.ReadLine()));
                    break;
            case 3:
                    Console.WriteLine("Ingrese radio del circulo");
                    resultado = CalculoDeArea.CalcularCirculo(int.Parse(Console.ReadLine()));
                    break;
            default:
                Console.WriteLine("Opcion incorrecta");
                break;
            }

            Console.WriteLine("El area es de: {0}", resultado);

            Console.ReadKey();

        }
    }
}
