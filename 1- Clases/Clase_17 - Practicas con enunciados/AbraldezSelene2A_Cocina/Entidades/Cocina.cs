using System;

namespace Entidades
{
    public class Cocina
    {
        #region Atributos
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;
        #endregion

        #region Propiedades
        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return _esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return _precio;
            }
        }
        #endregion

        #region Metodos

        #region Constructores 
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            if (obj is Cocina)
            {
                if ((Cocina)obj == this)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            if (a._precio == b._precio && a._esIndustrial == b._esIndustrial && a._codigo == b._codigo)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return ("Codigo: " + this._codigo + " - Precio: " + this._precio + " - ¿Es industrial?: " + this._esIndustrial);
        }
        #endregion

        #endregion

    }
}
