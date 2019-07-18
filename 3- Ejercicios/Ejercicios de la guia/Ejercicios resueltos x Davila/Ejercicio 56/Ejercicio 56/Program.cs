using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_56
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona("Juan", "Perez");
            try
            {
                Persona.Guardar(per);
            }
            catch (Exception)
            {
                Console.WriteLine("Lanzó excepción guardar.");
            }

            try
            {
                Persona per2 = Persona.Leer();
                Console.WriteLine(per2.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Lanzó excepción leer.");
            }
                        
            Console.ReadKey();
        }
    }
}
