using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Shopping
    {
        #region Atributos
        private int _capacidad;
        private List<Comercio> _comercios;
        #endregion

        #region Propiedades
        public double PrecioDeExportadores {
            get
            {
                return this.ObtenerPrecio(EComercio.Exportador);
            }
        }

        public double PrecioDeImportadores
        {
            get
            {
               return this.ObtenerPrecio(EComercio.Importador);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EComercio.Ambos);
            }
        }
        #endregion

        #region Metodos
        public static implicit operator Shopping(int capacidad)
        {
            Shopping s = new Shopping(capacidad);
            return s;
        }

        public static string Mostrar(Shopping s)
        {
            string retorno;
            retorno = "Capacidad del Shopping: " + s._capacidad + "\nTotal por Importadores: $" + s.PrecioDeImportadores + "\nTotal por Exportadores: $" + s.PrecioDeExportadores + "\nTotal: $" + s.PrecioTotal;
            retorno += "\n*********************\nListado de Comercios \n*********************\n";
            foreach(Comercio come in s._comercios)
            {
                if (come is Exportador)
                {
                    retorno += ((Exportador)come).Mostrar() + "\n";
                }
                else if (come is Importador)
                {
                    retorno += ((Importador)come).Mostrar() + "\n";
                }
            }
            return retorno;
        }

        public double ObtenerPrecio(EComercio tipoComercio)
        {
            double retorno = 0;
            foreach (Comercio come in this._comercios)
            {
                if (tipoComercio == EComercio.Exportador && come is Exportador)
                {
                    retorno += (Exportador)come;
                }
                else if (tipoComercio == EComercio.Importador && come is Importador) 
                {
                    retorno += (Importador)come;
                }
                else if (tipoComercio == EComercio.Ambos)
                {
                    if (come is Exportador)
                    {
                        retorno += (Exportador)come;
                    }
                    else if(come is Exportador)
                    {
                        retorno += (Importador)come;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Shopping s, Comercio c)
        {
            return !(s == c);
        }

        public static Shopping operator +(Shopping s, Comercio c)
        {
            if (s != c)
            {
                if (s._comercios.Count < s._capacidad)
                {
                    s._comercios.Add(c);
                }
                else
                {
                    Console.WriteLine("No hay mas lugar en el Shopping!");
                }
            }
            else
            {
                Console.WriteLine("El comercio ya se encuentra en el Shopping!");
            }
            return s;
        }

        public static bool operator ==(Shopping s, Comercio c)
        {
            bool retorno = false;
            foreach (Comercio come in s._comercios)
            {
                if (come is Exportador && c is Exportador)
                {
                    if (((Exportador)come) == ((Exportador)c))
                    {
                        retorno = true;
                        break;
                    }
                    else if (come is Importador && c is Importador)
                    {
                        if (((Importador)come) == ((Importador)c))
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            return retorno;
        }
        #region Constructores
        private Shopping()
        {
            this._comercios = new List<Comercio>();
        }

        private Shopping(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }
        #endregion

        #endregion
    }
}
