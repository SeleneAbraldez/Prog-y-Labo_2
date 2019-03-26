using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrenheits;

namespace Kelvins
{
    class Kelvin
    {
        double valor;

        public Kelvin(double valor)
        {
            this.valor = valor;
        }

        public double GetValor()
        {
            return this.valor;
        }

        public static implicit operator Kelvin(Fahrenheit f) 
        {
            double aux = (f.GetValor() + 459.67) * 5/9;
            Kelvin retorno = new Kelvin(aux);
            return retorno;            
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f) 
        {
            k.valor = k.valor + ((Kelvin)f).valor;
            return k;            
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            k.valor = k.valor - ((Kelvin)f).valor;
            return k;
        }

        public static Kelvin operator ++(Kelvin k)
        {
            k.valor++;
            return k;
        }

        public static Kelvin operator --(Kelvin k)
        {
            k.valor--;
            return k;
        }

        public static bool operator == (Kelvin k, Fahrenheit f)
        {
            bool retorno = false;
            if(k.valor == ((Kelvin)f).valor){
                retorno = true;
            }
           
            return retorno;
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            bool retorno = true;
            if (k.valor == ((Kelvin)f).valor)
            {
                retorno = false;
            }

            return retorno;
        }




    }
}


