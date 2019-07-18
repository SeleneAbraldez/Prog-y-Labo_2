using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_03";

            int num;
            int  contador = 0, resto;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) { //calculo hasta el numero puesto
                for (int j = 1; j <= i; j++) { 
                    resto = i % j; 
                    if (resto == 0)
                        contador++;
                }
                if (contador <= 2)
                    Console.Write("{0} ", i);
                contador = 0;
            }
            Console.ReadLine();
        }
    }
}
