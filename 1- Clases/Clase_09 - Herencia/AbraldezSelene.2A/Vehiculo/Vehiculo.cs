using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Vehiculo
    {
        #region Atributos
        public string patente;
        public EMarca marca;
        public int cantRuedas;
        #endregion

        public Vehiculo(string pat, EMarca marc, int cantR)
        {
            this.patente = pat;
            this.marca = marc;
            this.cantRuedas = cantR;
        }

        public string MostrarVehiculo()
        {
            return "Patente: " + this.patente + " - Marca: " + this.marca.ToString() + " - Cantidad de ruedas: " + this.cantRuedas.ToString();
        }


    }
}
