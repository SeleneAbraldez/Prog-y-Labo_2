using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string ruta, string datos)
        {
            StreamWriter file = new StreamWriter(ruta, true);
            file.WriteLine(datos);
            file.Close();
        }

        public static string Leer(string ruta)
        {
            try
            {
                StreamReader file = new StreamReader(ruta);
                string retorno = file.ReadToEnd();
                file.Close();
                return retorno;
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
        }
    }
}
