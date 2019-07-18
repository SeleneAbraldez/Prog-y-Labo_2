using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Validacion {
        public static bool Validar (int valor, int min, int max) {
            if (valor > min && valor < max) {
                return true;
            } else {
                return false;
            }
        }
    }
}
