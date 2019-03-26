using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class Excepcion
    {

        public Excepcion()
        {
            try
            {
                Excepcion.MetodoEstatico();  //4) llama al metodo que lanza una excepciòn DivideByZero()
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
                new Excepcion(); //3) Crea un nuevo objeto con el constructor por defecto
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("Una Exception", e); ; //5) Captura DivideByZero y la lanza como UnaException 
            }
            
        }


        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
            
        }



    }
}
