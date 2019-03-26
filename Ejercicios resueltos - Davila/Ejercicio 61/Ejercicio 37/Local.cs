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
    public class Local:Llamada,IGuardar<string>
    {
        #region Atributos
        protected float _costo;
        private string rutaDeArchivo;
        #endregion

        #region Propiedades
        public override float CostoLlamada 
        { 
            get 
            {
                return this.CalcularCosto();
            } 
        }

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
        #endregion

        #region Constructores
        public Local(Llamada llamada, float costo) :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) :base(duracion,destino,origen)
        {
            this._costo = costo;
        }
        #endregion

        #region Métodos
        protected override string Mostrar()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendLine(base.Mostrar());
            salida.AppendFormat("\nCosto: {0}", this.CostoLlamada);

            return salida.ToString();  
        }

        private float CalcularCosto()
        {
            float costo = this._costo * this.Duracion;
            return costo;
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            bool retorno = false;
            string path = "Local.xml";
            XmlTextWriter writer = null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                writer = new XmlTextWriter(path, null);
                serializer.Serialize(writer, this);
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
            string path = "Local.xml";

            if (File.Exists(path))
            {
                XmlTextReader reader = null;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Llamada));
                    reader = new XmlTextReader(path);
                    Llamada l = (Llamada)serializer.Deserialize(reader);
                    if (l is Local)
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
        #endregion
    }
}
