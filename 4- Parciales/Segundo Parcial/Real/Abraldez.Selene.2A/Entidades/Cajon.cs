using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void PrecioExcedido(double precio);
    public class Cajon<T>
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;

        public event PrecioExcedido eventoPrecio;

        public List<T> Elementos
        {
            get { return this._elementos; }
        }

        public double PrecioTotal
        {
            get {
                if (this._precioUnitario * this._elementos.Count > 55)
                {
                    this.eventoPrecio(this.PrecioTotal);
                }
                return this._precioUnitario * this._elementos.Count; }
        }

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precio, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad: {0} ", this._capacidad);
            sb.AppendFormat("Cantidad total de elementos: {0} ", this._elementos.Count);
            sb.AppendFormat("Precio Total: {0} ", this.PrecioTotal);

            foreach (T elem in this._elementos)
            {
                if (elem != null)
                {
                    sb.AppendLine(elem.ToString());
                }
            }

            return sb.ToString();
        }

        public static Cajon<T> operator +(Cajon<T> cajon, T elem)
        {
            if (cajon._elementos.Count < cajon._capacidad)
            {
                cajon._elementos.Add(elem);
            }
            else
            {
                throw new CajonLlenoException("El cajon ya se encuentra lleno");
            }
            return cajon;
        }

        public bool Xml(string path)
        {
            string pathValid = @"\" + path;
            bool retorno = false;
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(Cajon<T>));
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
    }
}
