using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            try
            { 
                Console.Write("Ingrese un numero: ");
                i = ParseadorDeEnteros.Parse(Console.ReadLine());
                Console.WriteLine("Su numero es: {0}", i);
                Console.ReadKey();
            }
            catch (ErrorParserException e)
            {
                Console.WriteLine(e.InnerException.Message);
                Console.ReadKey();
            }
            
        }
    }
}
