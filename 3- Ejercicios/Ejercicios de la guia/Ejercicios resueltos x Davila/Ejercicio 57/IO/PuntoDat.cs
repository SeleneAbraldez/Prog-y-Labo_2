using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{

    [Serializable]
    public class PuntoDat : Archivo, IArchivo<PuntoDat>
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
            if(Regex.IsMatch(ruta,@".+\.dat$"))
            {
                try
                {
                    if(base.ValidarArchivo(ruta))
                        retorno = true;
                }
                catch(FileNotFoundException e)
                {                    
                    throw new ArchivoIncorrectoException("El archivo no es correcto.",e);
                }                
            }
            else
            {
                throw new ArchivoIncorrectoException("El archivo no es un .dat");
            }

            return retorno;
        }

        public bool Guardar(string ruta)
        {
            bool retorno = false;
            FileStream stream = null;
            BinaryFormatter formatter = new BinaryFormatter();
            stream = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            retorno = true;
            stream.Close();

            return retorno;
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat dat = new PuntoDat();
            FileStream stream = null;
            if (ValidarArchivo(ruta))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream(ruta, FileMode.Open);
                dat = (PuntoDat)formatter.Deserialize(stream);
                stream.Close();
            }

            return dat;
        }
    }
}
