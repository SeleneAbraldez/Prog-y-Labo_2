using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Importador : Comercio
    {
        #region Atributos
        public EPaises paisOrigen;
        #endregion

        #region Metodos
        public static implicit operator double(Importador n)
        {
            return n._precioAlquiler;
        }
        #region Constructores
        public Importador(string nombreComercio, float precioAlquiler, Comerciante comerciante, EPaises paisOrigen) : base(nombreComercio, comerciante, precioAlquiler)
        {
            this.paisOrigen = paisOrigen;
        }
        #endregion
        

        public string Mostrar()
        {
            return ((string)this + "\nPais de origen: " + this.paisOrigen + "\n");
        }

        public static bool operator !=(Importador a, Importador b)
        {
            return !(a == b);
        }

        public static bool operator ==(Importador a, Importador b)
        {
            if (a.paisOrigen == b.paisOrigen && (Comercio)a == b)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
