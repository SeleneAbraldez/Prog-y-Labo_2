using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        #region Atributos
        public double cilindrada;
        #endregion

        public Moto(string pat, EMarca marc, int cantR, double cili) : base(pat, marc, cantR)
        {
            this.cilindrada = cili;
        }

        public string MostrarMoto()
        {
            return base.MostrarVehiculo() + " - Cilindrada: " + this.cilindrada.ToString();
        }



    }
}
