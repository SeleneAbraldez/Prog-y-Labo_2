using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase06;

namespace Clase06_test
{
    //prueba en clase para chequear que ande el codigo y como funciona
    class Program
    {
        static void Main(string[] args)
        {
            Paleta p = 8; //paso cantidad maxima
            Console.Write((string)p); //mando a escribir el string p, pero como no hay nada cargado, van a ser null
            Console.ReadKey();
        }
    }
}
