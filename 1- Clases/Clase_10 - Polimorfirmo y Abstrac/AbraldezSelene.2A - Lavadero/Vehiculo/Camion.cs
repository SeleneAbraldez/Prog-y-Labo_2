using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        #region Atributos
        protected float _tara;
        #endregion

        #region Propiedades
        public override double Precio { get; set; }
        #endregion

        #region Contructores
        public Camion(string pat, EMarca marc, byte cantR, float tar) : base(pat, marc, cantR)
        {
            this._tara = tar;
        }
        #endregion

        #region Metodos

        #region Polimorfismo 
        public override string Mostrar()
        {
            return base.Mostrar() + " - Tara: " + this._tara.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        public override double CalcularPrecioConIVA()
        {
            return (this.Precio * 1.21);
        }


        #endregion

    }
}
