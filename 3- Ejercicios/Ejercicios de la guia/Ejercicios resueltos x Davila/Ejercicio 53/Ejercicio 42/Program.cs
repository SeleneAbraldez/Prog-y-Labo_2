using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = String.Format("{0}{1}{2}-{3}{4}.txt",DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,DateTime.Now.Hour,DateTime.Now.Minute);

            try
            {
                OtraClase aux = new OtraClase();
                aux.MetodoInstancia();  //1)Llama al metodo de la clase OtraClase...
            }
            catch(Exception e) 
            { //9) Aca llega DivideByZero + UnaException + MiException
                if (!object.ReferenceEquals(e.InnerException, null))
                {
                    do
                    {
                        Console.WriteLine(e.Message);
                        ArchivoTexto.Guardar(ruta,e.Message);
                        e = e.InnerException;
                    } while (!object.ReferenceEquals(e, null));
                }
            }
            Console.ReadKey();

        }
    }
}
