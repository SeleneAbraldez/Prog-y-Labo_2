using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15 {
    class Calculadora {

        static bool Validar(double num2) {
            if (num2 != 0) {
                return true;
            } else {
                return false;
            }
        }

        public static double Calcular(double num1, double num2, char operacion) {
            double resultado = 0;
            switch (operacion) {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if(Validar(num2)){
                        resultado = num1 / num2;
                    } else {
                        Console.WriteLine("\nError- El divisor no puede ser igual a 0");
                        Console.ReadKey();
                        System.Environment.Exit(1);
                        break;
                    }       
                    break;
                default:
                    Console.WriteLine("\nError- Opcion incorrecta");
                    Console.ReadKey();
                    System.Environment.Exit(1);
                    break;
            }
            return resultado;
        }
    }
}
