using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            do
            {
                Console.Write("\nIngrese un número: ");
                int numero, contador = 0;
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    for (int i = 1; i < numero; i++)
                    {
                        contador = 0;
                        for(int j = 1; j < numero; j++){
                            if (i % j == 0)
                            {
                                contador++;
                            }
                        }        
                        

                        if(contador == 2){
                            Console.WriteLine("{0}", i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un valor válido.");
                }

                Console.Write("Presione S para continuar.");
                continuar = Console.ReadKey().KeyChar;

            } while (continuar == 's' || continuar == 'S');

            Console.ReadKey();


        }
    }
}
