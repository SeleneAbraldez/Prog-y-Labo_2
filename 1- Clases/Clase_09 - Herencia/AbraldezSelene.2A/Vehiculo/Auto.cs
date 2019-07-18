using System;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        #region Atributos 
        public int cantAsientos;
        #endregion

        public Auto(string pat, EMarca marc, int cantR, int cantA) : base(pat, marc, cantR)
        {
            this.cantAsientos = cantA;
        }

        public string MostrarAuto()
        {
            return base.MostrarVehiculo() + " - Cantidad de asientos: " + this.cantAsientos.ToString();
        }






    }
}
