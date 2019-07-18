using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char respuesta){
            bool retorno = false;
            if (respuesta == 's' || respuesta == 'S')
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
