using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        #region Constructores
        public Pluma() : this("Sin marca", null, 0)
        {
        }

        public Pluma(string marca) : this(marca, null, 0)
        {
        }

        public Pluma(string marca, Tinta tinta) : this(marca, tinta, 0)
        {
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._marca = marca;
            this._tinta = tinta;
            this._cantidad = cantidad;
        }
        #endregion

        private string Mostrar()
        {
            return "Marca: " + this._marca + ", " + Tinta.Mostrar(this._tinta);
        }

        public static bool operator ==(Pluma tintaPluma, Tinta tipito)
        {
            return (tintaPluma._tinta == tipito);
        }

        public static bool operator !=(Pluma tintaPluma, Tinta tipito)
        {
            return !(tintaPluma == tipito);
        }

        public static implicit operator string(Pluma plumita)
        {
            return plumita.Mostrar();
        }

        

    }
}
