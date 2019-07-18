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

        #region Contructores
        public Camion(string pat, EMarca marc, byte cantR, float tar) : base(pat, marc, cantR)
        {
            this._tara = tar;
        }
        #endregion

        #region Metodos
        public string MostrarCamion()
        {
            return base.MostrarVehiculo() + " - Tara: " + this._tara.ToString();
        }
        #endregion





    }
}
