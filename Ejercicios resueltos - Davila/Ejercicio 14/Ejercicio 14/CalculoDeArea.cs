using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {

        public static double CalcularCuadrado(double lado)
        {
            double retorno = 0;
            retorno = Math.Pow(lado, 2);
            return retorno;
        }

        public static double CalcularTriangulo(double xbase, double altura)
        {
            double retorno = 0;
            retorno = (xbase * altura) / 2;
            return retorno;
        }

        public static double CalcularCirculo(double radio)
        {
            double retorno = 0;
            retorno = Math.PI * Math.Pow(radio, 2);
            return retorno;
        }
    }
}
