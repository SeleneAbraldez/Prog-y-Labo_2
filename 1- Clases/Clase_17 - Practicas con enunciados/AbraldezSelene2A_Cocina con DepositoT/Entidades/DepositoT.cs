using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Deposito<T>
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<T> _lista;
        #endregion

        #region Metodos

        #region Contructor
        public Deposito(int capacidad)
            {
                this._capacidadMaxima = capacidad;
                this._lista = new List<T>();
            }
        #endregion

        private int GetIndice(T t)
        {
            int indice = -1;
            int i = 0;
            foreach (T te in this._lista)
            {
                if (this._lista[i].Equals(t))
                {
                    indice = i;
                }
                i++;
            }
            return indice;
        }

        public bool Agregar(T t)
        {
            bool retorno = false;
            if (this + t)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool Remover(T t)
        {
            bool retorno = false;
            if (this - t)
            {
                retorno = true;
            }
            return retorno;
        }


        #region Sobrecarga
        public static bool operator -(Deposito<T> d, T t)
        {
            bool retorno = false;
            int indice = d.GetIndice(t);
            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator +(Deposito<T> d, T t)
        {
            bool retorno = false;
            bool bandera = false;
            foreach (T te in d._lista)
            {
                if (te is T && t is T)
                {
                    //if ((T)te == (T)t)
                    if(te.Equals(t))
                    {
                        bandera = true;
                        break;
                    }
                }
            }
            if (bandera != true)
            {
                if (d._lista.Count < d._capacidadMaxima)
                {
                    d._lista.Add(t);
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        public override string ToString()
        {
            string retorno = "";
            retorno += "Capacidad maxima: " + this._capacidadMaxima + "\nListado de " + typeof(T).Name + ": \n";
            foreach (T te in this._lista)
            {
                retorno += te.ToString() + "\n";
            }
            return retorno;
        }

        #endregion
    }
}

