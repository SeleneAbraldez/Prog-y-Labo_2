using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_72
{
    static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese un numero: ");
                long l = long.Parse(Console.ReadLine());
                Console.WriteLine("Numero de {0} digitos", l.CantidadDeDigitos());
            }
        }

        public static int CantidadDeDigitos(this long longNum)
        {
            return (longNum.ToString()).Length;
        }
    }

   

}
