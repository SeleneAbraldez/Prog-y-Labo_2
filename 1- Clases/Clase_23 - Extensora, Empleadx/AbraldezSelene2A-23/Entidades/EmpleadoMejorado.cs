using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EmpleadoMejorado
    {
        #region Atributos
        private string _nombre;
        private int _legajo;
        private float _sueldo;
        #endregion

        #region Eventos
        public DelSueldo _delLimiteSueldo;
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return this._nombre; }
            set { _nombre = value; }
        }

        public int Legajo
        {
            get { return this._legajo; }
            set { _legajo = value; }
        }

        public float Sueldo
        {
            get { return this._sueldo; }
            set
            {
                if (value > 12000)
                {
                    EmpleadoSueldoArgs empSA = new EmpleadoSueldoArgs();
                    empSA.Sueldo = value;
                    this._delLimiteSueldo(this, empSA);
                }
                else
                {
                    _sueldo = value;
                }
            }
        }
        #endregion


        #region Metodos


        #region Poli
        public override string ToString()
        {
            return ("Empleadx " + this.Nombre + " con legajo de " + this.Legajo.ToString() + " tiene asignado un sueldo de " + this.Sueldo.ToString());
        }
        #endregion
        #endregion
    }
}
