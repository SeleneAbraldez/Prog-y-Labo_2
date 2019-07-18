using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Vehiculo
    {
        #region Atributos
        protected string _patente;
        protected EMarca _marca;
        protected byte _cantRuedas;
        #endregion

        #region Propiedades
        private string getPatente
        {
            get
            {
                return this._patente;
            }
        }

        private EMarca getMarca
        {
            get
            {
                return this._marca;
            }
        }
        #endregion

        #region Constructores
        public Vehiculo(string pat, EMarca marc, byte cantR)
        {
            this._patente = pat;
            this._marca = marc;
            this._cantRuedas = cantR;
        }
        #endregion

        #region Metodos
        protected string MostrarVehiculo()
        {
            return "Patente: " + this._patente + " - Marca: " + this._marca.ToString() + " - Cantidad de ruedas: " + this._cantRuedas.ToString();
        }
        #endregion

        #region Operadores 
        public static bool operator ==(Vehiculo veh1, Vehiculo veh2)
        {
            if (veh1._patente == veh2._patente && veh1._marca == veh2._marca)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vehiculo veh1, Vehiculo veh2)
        {
            return !(veh1 == veh2);
        }
        #endregion

    }
}
