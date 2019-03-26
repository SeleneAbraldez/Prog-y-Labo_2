using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class NumeroDecimal
    {
        public double numero;
        private NumeroDecimal(double numero)
        {
            this.numero = numero;    
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            NumeroDecimal retorno = new NumeroDecimal(numero);
            return retorno;
        }

        public static explicit operator double(NumeroDecimal numero)
        {
            double retorno = numero.numero;
            return retorno;
        }

        public static double operator +(NumeroDecimal nDecimal, NumeroBinario nBinario)
        {
            double retorno = nDecimal.numero + Conversor.BinarioDecimal(nBinario.numero);
            return retorno;
        }

        public static double operator -(NumeroDecimal nDecimal, NumeroBinario nBinario)
        {
            double retorno = nDecimal.numero - Conversor.BinarioDecimal(nBinario.numero);
            return retorno;
        }

        public static bool operator ==(NumeroDecimal nDecimal, NumeroBinario nBinario)
        {
            bool retorno = false;
            if(nDecimal.numero == Conversor.BinarioDecimal(nBinario.numero))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(NumeroDecimal nDecimal, NumeroBinario nBinario)
        {
            bool retorno = false;
            if (nDecimal.numero != Conversor.BinarioDecimal(nBinario.numero))
            {
                retorno = true;
            }
            return retorno;
        }


    }
}
