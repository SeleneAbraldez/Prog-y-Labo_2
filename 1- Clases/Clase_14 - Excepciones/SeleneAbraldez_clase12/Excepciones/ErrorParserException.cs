using System;

namespace Excepciones
{
    public class ErrorParserException : Exception
    {
        public ErrorParserException(string message, Exception exception) : base(message, exception)
        {
            Console.Write("El string no podra ser convertido " + message);
        }
    }
}
