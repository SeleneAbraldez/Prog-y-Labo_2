using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_04";

            int cont = 0;
            int i = 0; //numero predefinido para ir aumentando con el while
            int j; //j definido afuera para usarlo
            int suma;
            float resto;


            while (cont != 4) {
                i++;
                suma = 0;
                for (j = 1; j < i; j++) {
                    resto = i % j;
                    if (resto == 0) {
                        suma = suma + j;
                    }
                }
                if (suma == i) {
                    Console.WriteLine("{0} - Numero: {1}", cont+1, j);
                    cont++;
                }
            }
            Console.ReadLine();
        }
    }
}
