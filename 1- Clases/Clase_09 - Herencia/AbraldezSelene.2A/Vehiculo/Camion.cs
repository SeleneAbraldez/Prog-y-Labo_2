using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        #region Atributos
        public double tara;
        #endregion

        public Camion(string pat, EMarca marc, int cantR, double tar) : base(pat, marc, cantR)
        {
            this.tara = tar;
        }

        public string MostrarCamion()
        {
            return base.MostrarVehiculo() + " - Tara: " + this.tara.ToString();
        }





    }
}
