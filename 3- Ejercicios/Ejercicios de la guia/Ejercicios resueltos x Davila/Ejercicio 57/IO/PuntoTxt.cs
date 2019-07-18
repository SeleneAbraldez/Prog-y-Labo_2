using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo,IArchivo<string>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public override bool ValidarArchivo(string ruta)
        {
            bool retorno = false;
            if (Regex.IsMatch(ruta, @".+\.txt$"))
            {
                try
                {
                    if (base.ValidarArchivo(ruta))
                        retorno = true;
                }
                catch (FileNotFoundException e)
                {
                    throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
                }
            }
            else
            {
                throw new ArchivoIncorrectoException("El archivo no es un .txt");
            }

            return retorno;
        }

        public bool Guardar(string ruta)
        {
            bool retorno = false;
            StreamWriter file = new StreamWriter(ruta, false);
            file.WriteLine(this.Contenido);
            retorno = true;
            file.Close();
            
            return retorno;
        }

        public string Leer(string ruta)
        {
            string retorno = "";
            if (ValidarArchivo(ruta))
            {
                StreamReader file = new StreamReader(ruta);
                retorno = file.ReadToEnd();
                file.Close();
            }

            return retorno;        
        }
    }
}
