using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Excepcion
    {

        public Excepcion()
        {
            try
            {
                Excepcion.MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

        public Excepcion(int a)
        {
            try
            {
                new Excepcion();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("Una Exception", e); ;
            }
            
        }


        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
            
        }



    }
}
