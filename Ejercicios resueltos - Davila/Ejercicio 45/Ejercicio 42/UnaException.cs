using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class UnaException : Exception
    {
        public UnaException(string message, Exception innerException):base(message,innerException) //6 Crea la nueva excepcion almacenando como inner exception la divide by zero. 
        {
        }
    }
}
