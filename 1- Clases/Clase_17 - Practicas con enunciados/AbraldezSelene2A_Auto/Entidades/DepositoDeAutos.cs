using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DepositoDeAutos
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Auto> _lista;
        #endregion

        #region Metodos

        #region Contructor
        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }
        #endregion

        private int GetIndice(Auto a)
        {
            int indice = -1;
            int i = 0;
            foreach (Auto aut in this._lista)
            { 
                if (aut == a)
                {
                    indice = i;
                }
                i++;
            }
            return indice;
        }

        public bool Agregar(Auto a)
        {
            bool retorno = false;
            if(this + a)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool Remover(Auto a)
        {
            bool retorno = false;
            if (this - a)
            {
                retorno = true;
            }
            return retorno;
        }

       

        #region Sobrecarga
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);
            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            //else
            //{
            //    Console.WriteLine("El auto no se encuentra en el deposito!");
            //}
            return retorno;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            bool bandera = false;
            foreach (Auto aut in d._lista)
            {
                if (aut is Auto && a is Auto)
                {
                    if ((Auto)aut == (Auto)a)
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
                    d._lista.Add(a);
                    retorno = true;
                }
            }
            //else
            //{
            //    Console.WriteLine("El auto no se encuentra en el deposito!");
            //}
            return retorno;
        }
        #endregion

        public override string ToString()
        {
            string retorno = "";
            Console.WriteLine("Capacidad maxima: {0}", this._capacidadMaxima);
            Console.WriteLine("Listado de Autos: ");
            foreach (Auto aut in this._lista)
            {
                retorno += aut.ToString() + "\n";
            }
            return retorno;
        }

        #endregion
    }
}
