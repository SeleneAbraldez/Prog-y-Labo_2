using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa.Sellada;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaExternaSellada p1 = new PersonaExternaSellada("Vero", "Bustos", 21, Entidades.Externa.Sellada.ESexo.Femenino);

            Console.WriteLine(p1.NombreExt());

            Console.ReadKey();
        }
    }
}
