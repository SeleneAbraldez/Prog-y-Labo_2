using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Comercio
    {
        #region Atributos
        protected int _cantidadDeEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombre;
        protected float _precioAlquiler;
        #endregion

        #region Propiedades
        public int CantidadDeEmpleados {
            get
            {
                if (this._cantidadDeEmpleados == 0)
                {
                    this._cantidadDeEmpleados = Comercio._generadorDeEmpleados.Next(1, 100); 
                }
                return this._cantidadDeEmpleados;
            }
        }
        #endregion


        #region Metodos

        #region Constructores
        static Comercio()
        {
            Comercio._generadorDeEmpleados = new Random();    
        }

        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido) : this(nombreComercio, new Comerciante(nombre, apellido), precioAlquiler)
        {
        }

        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler)
        {
            this._nombre = nombre;
            this._comerciante = comerciante;
            this._precioAlquiler = precioAlquiler;
        }
        #endregion

        public static explicit operator string(Comercio c)
        {
            return  Comercio.Mostrar(c);
        }

        private static string Mostrar(Comercio c)
        {
            return ("NOMBRE: " + c._nombre + "\nCANTIDAD DE EMPLEADXS: " + c.CantidadDeEmpleados + "\nPRECIO ALQUILER: $" + c._precioAlquiler + "\nCOMERCIANTE: " + c._comerciante);
        }

        public static bool operator !=(Comercio a, Comercio b)
        {
            return !(a==b);
        }

        public static bool operator ==(Comercio a, Comercio b)
        {
            if(a._nombre == b._nombre && a._comerciante == b._comerciante)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
