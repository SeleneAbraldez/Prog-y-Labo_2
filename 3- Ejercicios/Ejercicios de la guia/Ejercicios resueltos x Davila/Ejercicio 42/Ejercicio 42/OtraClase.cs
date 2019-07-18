using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                new Excepcion(0);
            }
            catch (Exception e)
            {

                throw new MiException("Mi Excepcion",e);
            }
        }
    }
}
