using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celsiuss;
using Kelvins;

namespace Fahrenheits
{
    public class Fahrenheit
    {
        double valor;

        public Fahrenheit(double valor)
        {
            this.valor = valor;
        }
        
        public double GetValor()
        {
            return this.valor;
        }


        public static implicit operator Fahrenheit(Kelvin k)
        {
            double aux = k.GetValor() * 9/5 - 459.67;
            Fahrenheit retorno = new Fahrenheit(aux);
            return retorno;
        }

        public static implicit operator Fahrenheit(Celsius c)
        {
            double aux = c.GetValor() * 9/5 + 32;
            Fahrenheit retorno = new Fahrenheit(aux);
            return retorno;
        }


        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            f.valor = f.valor + ((Fahrenheit)k).valor;
            return f;
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            f.valor = f.valor + ((Fahrenheit)c).valor;
            return f;
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            f.valor = f.valor - ((Fahrenheit)k).valor;
            return f;
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            f.valor = f.valor - ((Fahrenheit)c).valor;
            return f;
        }

        public static Fahrenheit operator ++(Fahrenheit f)
        {
            f.valor++;
            return f;
        }

        public static Fahrenheit operator --(Fahrenheit f)
        {
            f.valor--;
            return f;
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            bool retorno = false;
            if (f.valor == ((Fahrenheit)k).valor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            bool retorno = false;
            if (f.valor == ((Fahrenheit)c).valor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            bool retorno = true;
            if (f.valor == ((Fahrenheit)k).valor)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            bool retorno = true;
            if (f.valor == ((Fahrenheit)c).valor)
            {
                retorno = false;
            }

            return retorno;
        }
    
    }
}
