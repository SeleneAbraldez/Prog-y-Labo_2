using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Exportador : Comercio
    {
        #region Atributos
        public ETipoProducto tipo;
        #endregion

        #region Metodos

        #region Constructores
        public Exportador(string nombreComercio, float precioAlquiler, string nombre, string apellido, ETipoProducto tipo) : base(precioAlquiler, nombreComercio, nombre, apellido) 
        {
            this.tipo = tipo;
        }
        #endregion
        public static implicit operator double(Exportador d)
        {
            return d._precioAlquiler;
        }

        public string Mostrar()
        { 
           return ((string)this + "\nTipo: " + this.tipo) + "\n";
        }

        public static bool operator !=(Exportador a, Exportador b)
        {
            return !(a == b);
        }

        public static bool operator ==(Exportador a, Exportador b)
        {
            if (a.tipo == b.tipo && (Comercio)a == b)
            {
                return true;
            }
            return false;
        }
        #endregion

    }
}
