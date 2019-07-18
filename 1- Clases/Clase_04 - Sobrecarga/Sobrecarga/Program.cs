using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nameSpaceClase_04;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa obj = new Cosa();
            //obj.EstablecerValor(3);
            //obj.EstablecerValor("Hola");
            Console.WriteLine(obj.Mostrar());

            Cosa obj2 = new Cosa(3);
            Console.WriteLine(obj2.Mostrar());

            Cosa obj3 = new Cosa(7, DateTime.Now.AddDays(15));
            Console.WriteLine(obj3.Mostrar());

            Cosa obj4 = new Cosa(6, new DateTime(2018, 12, 9), "Cositas");
            Console.WriteLine(obj4.Mostrar());

            Console.ReadKey();
        }
    }
}
