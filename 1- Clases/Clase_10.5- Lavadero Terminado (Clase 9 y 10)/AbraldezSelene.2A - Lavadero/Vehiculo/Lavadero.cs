using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Lavadero
    {
        #region Atributos
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;
        #endregion

        #region Propiedades
        public string MiLavadero
        {
            get {
                string retorno = "";

                foreach (Vehiculo v in this._vehiculos)
                {
                    retorno += v.Mostrar() + "/n";
                }

                return retorno;
            }
        }

        public List<Vehiculo> MisVehiculos
        {
            get {
                return this._vehiculos;
            }
        }
        #endregion

        #region Contructores

        private Lavadero()

        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precA, float precC, float precM) : this()
        {
            this._precioAuto = precA;
            this._precioCamion = precC;
            this._precioMoto = precM;
        }
        #endregion

        #region Metodos

        public double MostrarTotalFacturado(Lavadero lav)
        {
            return (MostrarTotalFacturado(EVehiculos.Auto) + MostrarTotalFacturado(EVehiculos.Moto) + MostrarTotalFacturado(EVehiculos.Camion));
        }

        public double MostrarTotalFacturado(EVehiculos vehiculos)
        {
            double precio = 0;
            foreach (Vehiculo v in this._vehiculos){
                if (vehiculos == EVehiculos.Auto && v is Auto)
                {
                    precio += this._precioAuto;
                } else if (vehiculos == EVehiculos.Moto && v is Moto){
                    precio += this._precioMoto;
                } else if (vehiculos == EVehiculos.Camion && v is Camion){
                    precio += this._precioCamion;
                }
            }
            return precio;
        }

        public static int OrdenarVehiculosPorPatentes(Vehiculo veh1, Vehiculo veh2)
        {
            return string.Compare(veh1.getPatente, veh2.getPatente);
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo veh1, Vehiculo veh2)
        {
            return string.Compare(veh1.getMarca.ToString() , veh2.getMarca.ToString());
        }


        #region Sobrecargas
        public static bool operator ==(Lavadero lav, Vehiculo veh)
        {
            foreach (Vehiculo v in lav._vehiculos)
            {
                if (v == veh)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Lavadero lav, Vehiculo veh)
        {
            return !(lav == veh);
        }

        public static Lavadero operator +(Lavadero lav, Vehiculo veh)
        {
            if (lav != veh)
            {
                lav._vehiculos.Add(veh);
            }
            return lav;
        }

        public static Lavadero operator -(Lavadero lav, Vehiculo veh)
        {
            if (lav == veh)
            {
                lav._vehiculos.Remove(veh);
            }
            return lav;
        }
        #endregion

        #endregion

    }
}