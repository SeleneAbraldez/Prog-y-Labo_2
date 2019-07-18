using System;

namespace Entidades
{
    public class Empleado
    {
        #region Atributos
        private string _nombre;
        private int _legajo;
        private float _sueldo;
        #endregion

        #region Eventos
        public DelegadoSueldo _limiteSueldo;
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
            set {
                if (value > 12000)
                {
                    this._limiteSueldo(this, value);
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
