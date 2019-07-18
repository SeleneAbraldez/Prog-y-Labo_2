using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_01"; //Muestra el titulo en la consola para no mostrar la direccion

            int num;
            int acum=0;
            int numMax=0;
            int numMin=0;
            float promedio;

            for (int i = 0; i < 5; i++){
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if(i==0){
                    numMax = num;
                    numMin = num;
                }else{
                    if (num > numMax){
                        numMax = num;
                    }
                    if (num < numMin){
                        numMin = num;
                    }
                }                               
                acum = acum + num;
            }

            promedio = (float)(acum / 5.0);

            System.Console.WriteLine("\n·El numero maximo es: {0}", numMax);
            System.Console.WriteLine("·El numero minimo es: {0}", numMin);
            System.Console.WriteLine("·El promedio es: {0}", promedio);
            System.Console.ReadKey();
        }
    }
}
