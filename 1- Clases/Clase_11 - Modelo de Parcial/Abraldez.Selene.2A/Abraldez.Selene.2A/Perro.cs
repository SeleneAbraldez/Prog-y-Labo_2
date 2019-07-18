using System;
using System.Collections.Generic;
using System.Text;

namespace Preparcial
{
    public class Perro : Mascota
    {
        #region Atributos
        private int edad;
        private bool esAlfa;
        #endregion

        #region Metodos
        #region Constructores
        public Perro(string nombre, string raza) : this (nombre, raza, 0, false)
        {       
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        protected override string Ficha()
        {
            string retorno = "";

            if (this.esAlfa == true)
            {
                retorno = base.Nombre + " " + base.Raza + ", alfa de la manada, edad " + this.edad.ToString();
            }
            else
            {
                retorno = base.Nombre + " " + base.Raza + ", edad " + this.edad.ToString();
            }
            return retorno;
        }

        #region Operators
        public static explicit operator int(Perro p)
        {
            return p.edad;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad == p2.edad)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        #endregion

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            if (obj is Perro)
            {
                if ((Perro)obj == this)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
