using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                new Excepcion(0); //2)Crea un nuevo objeto de la clase Excepcion usando el constructor que pide un int
            }
            catch (Exception e)
            {

                throw new MiException("Mi Excepcion",e); //7) Hasta aca esta DivideByZero + UnaException. Lanza nueva como MiException.
            }
        }
    }
}
