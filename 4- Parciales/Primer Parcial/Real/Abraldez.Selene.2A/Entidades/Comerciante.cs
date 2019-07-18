using System;

namespace Entidades
{
    public class Comerciante
    {
        #region Atributos
        private string apellido;
        private string nombre;
        #endregion

        #region Metodos

        #region Constructores
        public Comerciante(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        public static implicit operator string(Comerciante a)
        {
            return (a.nombre + " - " + a.apellido);
        }

        public static bool operator !=(Comerciante a, Comerciante b)
        {
            return !(a==b);
        }

        public static bool operator ==(Comerciante a, Comerciante b)
        {
            if (a.nombre == b.nombre && a.apellido == b.apellido)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
