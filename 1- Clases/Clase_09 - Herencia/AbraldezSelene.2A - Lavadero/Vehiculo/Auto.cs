using System;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        #region Atributos 
        public int _cantAsientos;
        #endregion

        public Auto(string pat, EMarca marc, byte cantR, int cantA) : base(pat, marc, cantR)
        {
            this._cantAsientos = cantA;
        }

        public string MostrarAuto()
        {
            return base.MostrarVehiculo() + " - Cantidad de asientos: " + this._cantAsientos.ToString();
        }






    }
}
