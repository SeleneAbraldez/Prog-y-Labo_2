using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Ejercicio_37
{
    public class Provincial:Llamada,IGuardar<string>
    {
        public enum Franja { Franja_1, Franja_2, Franja_3}

        protected Franja _franjaHoraria;
        private string rutaDeArchivo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }
        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
            }
        }

        public Provincial(Llamada llamada, Franja miFranja) 
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,miFranja)
        {
        }

        public Provincial(string origen, float duracion, string destino, Franja miFranja)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
        }

        protected override string Mostrar()        
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendLine(base.Mostrar());
            salida.AppendFormat("\nFranja Horaria: {0}", this._franjaHoraria);
            salida.AppendFormat("\nCosto: {0}", this.CostoLlamada);

            return salida.ToString();  
        }

        private float CalcularCosto()
        {
            float costo = 0;
            float retorno;

            switch (this._franjaHoraria)
            { 
                case Franja.Franja_1:
                    costo = (float)0.99;
                    break;
                case Franja.Franja_2:
                    costo = (float)1.25;
                    break;
                case Franja.Franja_3:
                    costo = (float)0.66;
                    break;
            }
             retorno = costo * this.Duracion;
            return retorno;
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            bool retorno = false;
            string path = "Provincial.xml";
            XmlTextWriter writer = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                writer = new XmlTextWriter(path,null);
                serializer.Serialize(writer,this);
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                writer.Close();
            }

            return retorno;
        }

        public string Leer()
        {
            string retorno = "";
            string path = "Provincial.xml";

            if (File.Exists(path))
            {
                XmlTextReader reader = null;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Llamada));
                    reader = new XmlTextReader(path);
                    Llamada l = (Llamada)serializer.Deserialize(reader);
                    if (l is Provincial)
                    {
                        retorno = l.ToString();
                    }
                    else
                    {
                        throw new InvalidCastException();
                    }
                }
                catch (InvalidCastException e)
                {
                    throw e;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }
            }
            return retorno;
        }
    }
}
