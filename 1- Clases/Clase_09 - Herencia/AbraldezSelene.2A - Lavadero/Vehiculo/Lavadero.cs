using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    class Lavadero
    {
        #region Atributos
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;
        #endregion

        #region Propiedades
        public string MiLavadero {
            get {
                string retorno = "";

                foreach(Vehiculo v in this._vehiculos)
                {
                    if(v is Auto)
                    {
                        retorno += ((Auto)v).MostrarAuto() + "/n";
                    }else if(v is Moto)
                    {
                        retorno += ((Moto)v).MostrarMoto() + "/n";
                    }else if (v is Camion)
                    {
                        retorno += ((Camion)v).MostrarCamion() + "/n";
                    }
                }

                return retorno;
            }
        }

        public List<Vehiculo> MisVehiculos
        {
            get
            {
                return this._vehiculos;
            }
        }
        #endregion

        #region Contructores
        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(List<Vehiculo> listV, float precA, float precC, float precM) : this()
        {
            this._precioAuto = precA;
            this._precioCamion = precC;
            this._precioMoto = precM;
            this._vehiculos = listV;
        }
        #endregion

        #region Metodos

        //public double MostrarTotalFacturado(EVehiculos EVe)
        //{
        //    double retorno;
        //    foreach(Vehiculo v in this._vehiculos)
        //    {
        //        retorno = ;
        //    }
        //    return retorno;
        //}

        public static int OrdenarVehiculosPorPatentes (Vehiculo veh1, Vehiculo veh2)
        {
            int retorno = -1;
            if (veh1._patente == veh2._patente)
            {
                retorno = 0;
            }else if (veh1._patente > veh2._patente)
            {
                retorno = 1;
            }
            return retorno;
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo veh1, Vehiculo veh2)
        {
            int retorno = -1;
            if (veh1._marca == veh2._marca)
            {
                retorno = 0;
            } else if (veh1._marca > veh2._marca)
            {
                retorno = 1;
            }
            return retorno;
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
                foreach (Vehiculo v in lav._vehiculos)
                {
                    if (lav._vehiculos == null)
                    {
                        lav._vehiculos.Add(veh);
                    }
                }
            }
            return lav;
        }

        public static Lavadero operator -(Lavadero lav, Vehiculo veh)
        {
            if (lav == veh)
            {
                foreach (Vehiculo v in lav._vehiculos)
                {
                    if (lav == veh)
                    {
                        lav._vehiculos.Remove(veh);
                    }
                } 
            }
            return lav;
        }
        #endregion

        #endregion

    }
}
