using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            Console.WriteLine("LISTA");
            List<int> lista = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(aleatorio.Next(-99, 99));
            }

            Console.WriteLine("DESORDENADO");
            foreach (int num in lista)
            {
                Console.Write("{0}; ", num);
            }

            lista.Sort();
            Console.WriteLine("\n\nPOSITIVOS");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] > 0)
                {
                    Console.Write("{0}; ", lista[i]);
                }
            }

            Console.WriteLine("\n\nNEGATIVOS");
            foreach (int num in lista)
            {
                if (num < 0)
                {
                    Console.Write("{0}; ", num);
                }
            }

            Console.ReadKey();

            Console.WriteLine("\n\n-----------------------------------------------------------------");
            Console.WriteLine("\n\nPILA");
            Stack pila = new Stack();

            foreach (int num in lista)
            {
                pila.Push(num);
            }

            Console.WriteLine("DESORDENADO");
            foreach (int num in pila)
            {
                Console.Write("{0}; ",num);
            }

            Console.WriteLine("\n\nPOSITIVOS");
            foreach (int num in pila)
            {
                if (num > 0) 
                {
                    Console.Write("{0}; ", num);
                }
            }

            pila.Clear();
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] < 0)
                {
                    pila.Push(lista[i]);
                }
            }

            Console.WriteLine("\n\nNEGATIVOS");
            foreach (int num in pila)
            {
                if (num < 0)
                {
                    Console.Write("{0}; ", num);
                }
            }
            Console.ReadKey();



            Console.WriteLine("\n\n-----------------------------------------------------------------");
            Console.WriteLine("\n\nCOLA");
            Queue cola = new Queue();

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                    cola.Enqueue(lista[i]);
            }


            Console.WriteLine("DESORDENADO");
            foreach (int num in cola)
            {
                Console.Write("{0}; ", num);
            }

            

            Console.WriteLine("\n\nPOSITIVOS");
            foreach (int num in cola)
            {
                if (num > 0)
                {
                    Console.Write("{0}; ", num);
                }
            }

            cola.Clear();

            foreach (int num in lista)
            {
               cola.Enqueue(num);
            }

            Console.WriteLine("\n\nNEGATIVOS");
            foreach (int num in cola)
            {
                if (num < 0)
                {
                    Console.Write("{0}; ", num);
                }
            }


            Console.ReadKey();
            

        }
    }
}
