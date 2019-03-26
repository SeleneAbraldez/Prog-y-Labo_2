using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                OtraClase aux = new OtraClase();
                aux.MetodoInstancia();  //1)Llama al metodo de la clase OtraClase...
            }
            catch(Exception e) 
            { //9) Aca llega DivideByZero + UnaException + MiException
                Console.WriteLine(e.Message);

                if (!object.ReferenceEquals(e.InnerException, null))
                {
                    Exception ex = e.InnerException;
                    do
                    {
                        Console.WriteLine(ex.Message);
                        ex = ex.InnerException;
                    } while (!object.ReferenceEquals(ex, null));
                }
            }
            Console.ReadKey();

        }
    }
}
