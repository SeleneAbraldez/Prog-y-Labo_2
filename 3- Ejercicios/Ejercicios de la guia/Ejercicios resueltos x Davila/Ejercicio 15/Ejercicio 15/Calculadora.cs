using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double numero1, double numero2, string operador)
        {
            double retorno = 0;

            switch (operador)
            {
                case "+":
                    retorno = numero1 + numero2;
                    break;

                case "-":
                    retorno = numero1 * numero2;
                    break;

                case "*":
                    retorno = numero1 * numero2;
                    break;

                case "/":
                    if(Calculadora.Validar(numero2))
                    {
                        retorno = numero1 / numero2;
                    }
                    else
                    {
                        retorno = 0;
                    }                    
                    break;

                default:
                    retorno = 0;
                    break;
            }

            return retorno;
        }

        private static bool Validar(double numero2)
        {
            bool retorno = false;

            if(numero2 != 0)
            {
                retorno = true;
            }

            return retorno;
        }

        public static void Mostrar(double resultado)
        {
            Console.WriteLine("Resultado = {0}", resultado);
        }
    }
}
