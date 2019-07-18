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

        #region Constructores
        public Moto(string pat, EMarca marc, byte cantR, float cili) : base(pat, marc, cantR)
        {
            this._cilindrada = cili;
        }
        #endregion

        #region Metodos
        public string MostrarMoto()
        {
            return base.MostrarVehiculo() + " - Cilindrada: " + this._cilindrada.ToString();
        }
        #endregion



    }
}
