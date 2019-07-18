using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        #region Atributos
        public float _cilindrada;
        #endregion

        #region Propiedades
        public override double Precio { get; set; }
        #endregion

        #region Constructores
        public Moto(string pat, EMarca marc, byte cantR, float cili) : base(pat, marc, cantR)
        {
            this._cilindrada = cili;
        }
        #endregion

        #region Metodos

        #region Polimorfismo
        public override string Mostrar()
        {
            return base.Mostrar() + " - Cilindrada: " + this._cilindrada.ToString();
        }

        public override string ToString()
        {
            return base.Mostrar();
        }
        #endregion

        public override double CalcularPrecioConIVA()
        {
            return (this.Precio * 1.21);
        }

        #endregion

    }
}
