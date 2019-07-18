using System;
using System.Collections.Generic;
using System.Text;

namespace Preparcial
{
    public class Gato : Mascota
    {
        #region Metodos
        #region Constructores
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }
        #endregion
 
        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        #region Operators
        public static bool operator ==(Gato g1, Gato g2)
        {
            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        #endregion
        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                if ((Gato)obj == this)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
