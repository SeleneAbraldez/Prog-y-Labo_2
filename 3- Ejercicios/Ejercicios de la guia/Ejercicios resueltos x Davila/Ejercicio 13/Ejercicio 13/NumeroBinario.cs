using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    
    class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;    
        }

        public static implicit operator NumeroBinario(string numero)
        {
            NumeroBinario retorno = new NumeroBinario(numero);
            return retorno;
        }

        public static explicit operator string(NumeroBinario numero)
        {
            string retorno = numero.numero;
            return retorno;
        }

        public static string operator +(NumeroBinario nBinario, NumeroDecimal nDecimal)
        {
            double buffer = nDecimal.numero + Conversor.BinarioDecimal(nBinario.numero);
            string retorno = Conversor.DecimalBinario(buffer);
            return retorno;
        }

        public static string operator -(NumeroBinario nBinario, NumeroDecimal nDecimal)
        {
            double buffer = nDecimal.numero - Conversor.BinarioDecimal(nBinario.numero);
            string retorno = Conversor.DecimalBinario(buffer);
            return retorno;
        }

        public static bool operator ==(NumeroBinario nBinario, NumeroDecimal nDecimal)
        {
            bool retorno = false;
            if(nDecimal.numero == Conversor.BinarioDecimal(nBinario.numero))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(NumeroBinario nBinario, NumeroDecimal nDecimal)
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
