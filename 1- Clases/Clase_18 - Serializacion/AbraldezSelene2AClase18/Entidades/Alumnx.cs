using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Alumnx : Persona
    {
        #region Atributos
        private int _legajo;
        #endregion

        #region Propiedades
        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        #endregion

        #region Metodos
        #region Sobreescritura
        public override string ToString()
        {
            return (base.ToString() + " - Legajo: " + this.Legajo);
        }
        #endregion
        #endregion
    }
}
