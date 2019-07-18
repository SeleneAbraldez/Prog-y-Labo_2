using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Profesorx : Persona
    {
        #region Atributos
        private string _titulo;
        #endregion

        #region Propiedades
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        #endregion

        #region Metodos
        #region Sobreescritura
        public override string ToString()
        {
            return (base.ToString() + " - Titulo: " + this.Titulo);
        }
        #endregion
        #endregion
    }
}
