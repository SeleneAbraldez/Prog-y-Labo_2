using System;

namespace Entidades
{
    public class Auto
    {
        #region Atributos
        private string _color;
        private string _marca;
        #endregion

        #region Propiedades
        public string Color
        {
            get
            {
                return _color;
            }
        }

        public string Marca
        {
            get
            {
                return _marca;
            }
        }
        #endregion

        #region Metodos

        #region Constructores 
        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            if (obj is Auto)
            {
                if ((Auto)obj == this)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public static bool operator ==(Auto a, Auto b)
        {
            if (a._marca == b._marca && a._color == b._color)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return ("Marca: " + this._marca + " - Color: " + this._color);
        }
        #endregion

        #endregion

    }
}
