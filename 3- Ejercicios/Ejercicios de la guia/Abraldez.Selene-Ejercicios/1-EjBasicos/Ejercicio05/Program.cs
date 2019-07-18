//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ejercicio05 {
//    class Program {
//        static void Main(string[] args) {
//            Console.Title = "Ejercicio_05";

//            int num;

//            Console.Write("Ingrese un numero: ");
//            num = int.Parse(Console.ReadLine());


//            double aumento = 1,
//                i,
//                j,
//                sumaAtras,
//                sumaAdelante;

//            while (aumento < numero) {

//                aumento++;
//                sumaAtras = 0;
//                sumaAdelante = 0;

//                // Calculo para atras
//                for (i = 1; i < aumento; i++) {
//                    sumaAtras = sumaAtras + i;
//                }
//                //calculo para adelante
//                for (j = aumento + 1; j <= sumaAtras; j++) {
//                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
//                        break;
//                    sumaAdelante = sumaAdelante + j;
//                }

//                // Mostrando en pantalla
//                if (sumaAtras == sumaAdelante)
//                    Console.WriteLine("Es centro numerico: {0}", aumento);
//            }
//            Console.ReadLine();
//        }
//    }
//}
