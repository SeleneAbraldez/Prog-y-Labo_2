using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    #region ENUNCIADO
    //Generar una clase estática llamada ParseadoraDeEnteros.

    //Agregar un método TryParse(string, out int) : bool cuyo funcionamiento sea exactamente igual al de Int32.TryParse.
    //Agregar un método Parse(string) : int cuyo funcionamiento sea exactamente igual al de Int32.Parse.

    //Capturar por separado las excepciones:
    //*-FormatException: agregará al mensaje “... por error de formato”.
    //*-OverflowException: agregará al mensaje “... por tamaño del dato”

    //En caso de falla, deberá devolver la excepción ErrorParserException generada por el alumno, con el mensaje 
    //“El string no podrá ser convertido”. 
    //Utilizar la propiedad InnerException de la clase padre.
    //Dentro de ambos métodos, para convertir de String a Entero, utilizar Int32.Parse.Controlar las excepciones dentro de
    //los métodos y luego lanzarlas.

    //NOTAS:
    //El método Parse deberá capturar y lanzar (throw) la excepción capturada.  
    #endregion
    public static class ParseadorDeEnteros
    {
        public static bool TryParse(string s, out int oi)
        {
            bool retorno = false;
            try
            {
                oi = Int32.Parse(s);
                retorno = true;
            }
            catch (OverflowException e)
            {
                retorno = false;
                throw new ErrorParserException("... por error de tamaño. \n", e);
            }
            catch (FormatException e)
            {
                retorno = false;
                throw new ErrorParserException("... por error de formato. \n", e);
            }
            return retorno;
        }

        public static int Parse(string s)
        {
            try
            {
                return Int32.Parse(s);
            }
            catch (FormatException e)
            {
                throw new ErrorParserException("...por error de formato. \n", e);
            }
            catch (OverflowException e)
            {
                throw new ErrorParserException("...por error de tamaño. \n", e);
            }

        }
    }
}
