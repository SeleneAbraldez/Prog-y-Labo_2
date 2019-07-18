using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {20,-5,8,6,-8,99,78,62,11,02,877,-50,66,-32,96,-15,55,64,99,-78,-7};
            bool flagSwap;
            int aux;

            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write("{0}; ", array[i]);
            }


            do
            {
                flagSwap = false;
                for (int i = 0; i < (array.Length - 1); i++)
                {
                    if(array[i] < array[i+1])
                    {
                        flagSwap = true;
                        aux = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = aux;                        
                    }
                }
            } while (flagSwap);

            Console.Write("\n");
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                    Console.Write("{0}; ", array[i]);
            }


            do
            {
                flagSwap = false;
                for (int i = 0; i < (array.Length - 1); i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        flagSwap = true;
                        aux = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = aux;
                    }
                }
            } while (flagSwap);

            Console.Write("\n");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    Console.Write("{0}; ", array[i]);
            }


            
            Console.ReadKey();
            
        

        }
    }
}
