using System;
using System.Collections.Generic;
using System.Text;

namespace Preparcial
{
    public class Grupo
    {
        #region Atributos
        private List<Mascota> _manada;
        private string _nombre;
        private static EtipoManada _tipo;
        #endregion

        #region Propiedades
        public EtipoManada Tipo
        {
            set {
                _tipo = value;
            }
        }
        #endregion

        #region Metodos

        #region Constructores
        static Grupo()
        {
            Grupo._tipo = EtipoManada.Unica;
        }

        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        #region Operators
        public static implicit operator string(Grupo g)
        {
            string retorno = "";
            retorno = "Grupo: " + g._nombre + " - Tipo: " + Grupo._tipo + "\n+Integrantes <" + g._manada.Count + ">: \n";
            foreach (Mascota m in g._manada)
            {
                //if (m is Perro)
                //{
                //    retorno += (Perro)m + "\n";
                //}
                //else if (m is Gato){
                //    retorno += (Gato)m + "\n";
                //}
                retorno += m + "\n";
            }
            return retorno;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g._manada.Remove(m);
            }
            else
            {
                Console.WriteLine("{0} no se encuentra en el grupo!", m);
            }
            return g;
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g._manada.Add(m);
            }
            else
            {
                Console.WriteLine("{0} ya se encuentra en el grupo!", m);
            }
            return g;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            foreach (Mascota masc in g._manada)
            {
                if (masc == m)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }
        #endregion

        #endregion
    }
}
