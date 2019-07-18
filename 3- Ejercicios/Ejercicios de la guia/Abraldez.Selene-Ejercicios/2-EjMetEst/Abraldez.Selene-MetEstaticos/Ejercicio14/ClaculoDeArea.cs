using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14 {
    class CalculoDeArea {
        public static double CalcularCuadrado(double lado) {
            return (lado * lado);
            
        }

        public static double CalcularTriangulo(double baseT, double altura) {
            return ((baseT * altura)/2);
        }

        public static double CalcularCirculo(double radio) {
            return ((Math.PI)*(radio*radio));
        }
    }
}
