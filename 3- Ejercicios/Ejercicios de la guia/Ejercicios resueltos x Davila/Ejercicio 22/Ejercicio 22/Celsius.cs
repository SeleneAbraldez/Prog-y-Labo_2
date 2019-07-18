using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrenheits;

namespace Celsiuss
{
    class Celsius
    {
        double valor;

        public Celsius(double valor)
        {
            this.valor = valor;
        }

        public double GetValor()
        {
            return this.valor;
        }


        public static implicit operator Celsius(Fahrenheit f)
        {
            double aux = (f.GetValor() - 32) * 5 / 9;
            Celsius retorno = new Celsius(aux);
            return retorno;
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            c.valor = c.valor + ((Celsius)f).valor;
            return c;
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            c.valor = c.valor - ((Celsius)f).valor;
            return c;
        }

        public static Celsius operator ++(Celsius c)
        {
            c.valor++;
            return c;
        }

        public static Celsius operator --(Celsius c)
        {
            c.valor--;
            return c;
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            bool retorno = false;
            if (c.valor == ((Celsius)f).valor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            bool retorno = true;
            if (c.valor == ((Celsius)f).valor)
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
