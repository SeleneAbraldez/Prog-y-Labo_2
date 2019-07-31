using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Manzana : Fruta, IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre
        {
            get { return "Manzana"; }
        }
        public string Provincia
        {
            get { return this._provinciaOrigen; }
            set { this._provinciaOrigen = value; }
        }

        public override bool TieneCarozo
        {
            get { return true; }
        }

        public Manzana()
        {

        }

        public Manzana(string color, double peso, string provincia) : base(color, peso)
        {
            this.Provincia = provincia;
        }

        protected override string FrutasToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutasToString());
            sb.AppendFormat("Provincia de origen: {0}", this.Provincia);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutasToString();
        }


        public bool Xml(string path)
        {
            string pathValid = @"\" + path;
            bool retorno = false;
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Manzana));
                XmlTextWriter xw = new XmlTextWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + pathValid), Encoding.UTF8);

                sr.Serialize(xw, this);
                xw.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }


        bool IDeserializar.Xml(string path, out Fruta fru)
        {
            bool retorno = false;
            string pathValid = @"\" + path;
            fru = null;
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Manzana));
                XmlTextReader xr = new XmlTextReader(((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + pathValid)));
                fru = (Manzana)sr.Deserialize(xr);
                xr.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

    }
}
