using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Cocina> _lista;
        #endregion

        #region Metodos

        #region Contructor
        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }
        #endregion

        private int GetIndice(Cocina c)
        {
            int indice = -1;
            int i = 0;
            foreach (Cocina coc in this._lista)
            {
                if (coc == c)
                {
                    indice = i;
                }
                i++;
            }
            return indice;
        }

        public bool Agregar(Cocina c)
        {
            bool retorno = false;
            if (this + c)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool Remover(Cocina c)
        {
            bool retorno = false;
            if (this - c)
            {
                retorno = true;
            }
            return retorno;
        }


        #region Sobrecarga
        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            int indice = d.GetIndice(c);
            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
            //bool retorno = false;
            //if (d.GetIndice(c) != -1)
            //{
            //    d._lista.Remove(c);
            //    retorno = true;
            //}
            //return retorno;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            bool bandera = false;
            foreach (Cocina coc in d._lista)
            {
                if (coc is Cocina && c is Cocina)
                {
                    if ((Cocina)coc == (Cocina)c)
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
                    d._lista.Add(c);
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        public override string ToString()
        {
            string retorno = "";
            Console.WriteLine("Capacidad maxima: {0}", this._capacidadMaxima);
            Console.WriteLine("Listado de Cocinas: ");
            foreach (Cocina coc in this._lista)
            {
                retorno += coc.ToString() + "\n";
            }
            return retorno;
        }

        #endregion
    }
}
