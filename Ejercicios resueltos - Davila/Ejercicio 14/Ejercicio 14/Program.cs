using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double xbase, altura, resultado, lado, radio;
            bool validacion1, validacion2;

            Console.WriteLine("Calculo de Area:\n");
            Console.WriteLine("Triangulo:");            
            do
            {
                Console.WriteLine("\nIngrese la base:");
                validacion1 = double.TryParse(Console.ReadLine(), out xbase);
            } while (validacion1 == false);
            do
            {
                Console.WriteLine("\nIngrese la altura:");
                validacion2 = double.TryParse(Console.ReadLine(), out altura);
            } while (validacion2 == false);

            resultado = CalculoDeArea.CalcularTriangulo(xbase, altura);
            Console.WriteLine("Area del triangulo = {0}\n",resultado);

            Console.WriteLine("Cuadrado:");
            do
            {
                Console.WriteLine("\nIngrese el lado:");
                validacion1 = double.TryParse(Console.ReadLine(), out lado);
            } while (validacion1 == false);

            resultado = CalculoDeArea.CalcularCuadrado(lado);
            Console.WriteLine("Area del cuadrado = {0}\n", resultado);

            Console.WriteLine("Circulo:");
            do
            {
                Console.WriteLine("\nIngrese el radio:");
                validacion1 = double.TryParse(Console.ReadLine(), out radio);
            } while (validacion1 == false);

            resultado = CalculoDeArea.CalcularCirculo(radio);
            Console.WriteLine("Area del circulo = {0}\n", resultado);

            Console.ReadKey();

        }

    }
}
