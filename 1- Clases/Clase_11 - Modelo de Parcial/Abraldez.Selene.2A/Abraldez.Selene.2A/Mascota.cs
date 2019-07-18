using System;

namespace Preparcial
{
    public abstract class Mascota
    {
        #region Atributos
        private string _nombre;
        private string _raza;
        #endregion

        #region Propiedades
        public string Nombre {
            get
            {
                return _nombre;
            }
        }
        public string Raza {
            get
            {
                return _raza;
            }           
        }
        #endregion

        #region Metodos

        #region Constructores
        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }
        #endregion

        protected virtual string DatosCompletos()
        {
            return this.Nombre + " " +  this.Raza;
        }

        protected abstract string Ficha();
        
        #endregion
    }
}
