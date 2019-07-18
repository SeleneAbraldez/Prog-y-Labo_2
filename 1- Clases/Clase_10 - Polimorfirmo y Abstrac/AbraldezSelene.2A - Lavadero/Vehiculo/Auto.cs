using System;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        #region Atributos 
        public int _cantAsientos;
        #endregion

        #region Propiedades
        //ov abs
        public override double Precio { get; set; }
        #endregion

        #region Constructores
        public Auto(string pat, EMarca marc, byte cantR, int cantA) : base(pat, marc, cantR)
        {
            this._cantAsientos = cantA;
        }
        #endregion

        #region Metodos

        #region Polimorfismo 
        public override string Mostrar()
        {
           return base.Mostrar() + " - Cantidad de asientos: " + this._cantAsientos.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        //ov abs
        public override double CalcularPrecioConIVA()
        {
            return (this.Precio * 1.21);
        }

        #endregion


    }
}
