using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador();
            Console.WriteLine(suma.Sumar(1, 1));
            Console.ReadKey();
        }
    }
}
