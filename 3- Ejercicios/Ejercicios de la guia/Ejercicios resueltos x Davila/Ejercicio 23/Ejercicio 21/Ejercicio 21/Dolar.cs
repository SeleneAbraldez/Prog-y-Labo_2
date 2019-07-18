using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    public class Dolar
    {
        const double factorConversion = 1.3642;
        double _valor;

        public Dolar(double valor)
        {
            this._valor = valor;
        }

        public Dolar()
        {
            this._valor = 0;
        }

        public double getValor()
        {
            return this._valor;
        }

        public static explicit operator Dolar(Euro a)
        {
            Dolar retorno = new Dolar(a.getValor() * factorConversion);
            return retorno;
        }

        public static explicit operator Dolar(Pesos a)
        {
            Dolar retorno = new Dolar(a.getValor() / 17.55);
            return retorno;
        }

        public static explicit operator Dolar(double a)
        {
            Dolar retorno = new Dolar(a);
            return retorno;
        }

        public static Dolar operator + (Dolar a, Dolar b)
        {
            double newValue = a._valor + b._valor;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static Dolar operator + (Dolar a, Euro b)
        {
            double newValue = a._valor + ((Dolar)b)._valor;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static Dolar operator + (Euro a, Dolar b)
        {
            double newValue = ((Dolar)a)._valor + b._valor;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static Dolar operator +(Dolar a, double b)
        {
            double newValue = a._valor + b;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static Dolar operator +(double a, Dolar b)
        {
            double newValue = a + b._valor;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static Dolar operator -(Dolar a, Dolar b)
        {
            double newValue = a._valor - b._valor;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static Dolar operator -(Dolar a, Euro b)
        {
            double newValue = a._valor - ((Dolar)b)._valor;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static Dolar operator -(Euro a, Dolar b)
        {
            double newValue = ((Dolar)a)._valor - b._valor;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static Dolar operator -(Dolar a, double b)
        {
            double newValue = a._valor - b;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static Dolar operator -(double a, Dolar b)
        {
            double newValue = a - b._valor;
            Dolar retorno = new Dolar(newValue);
            return retorno;
        }

        public static bool operator == (Dolar a, Dolar b)
        {
            bool retorno = false;
            if(a._valor == b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar a, Dolar b)
        {
            bool retorno = false;
            if (a._valor != b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Dolar a, Euro b)
        {
            bool retorno = false;
            if (a._valor == ((Dolar)b)._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar a, Euro b)
        {
            bool retorno = false;
            if (a._valor != ((Dolar)b)._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro a, Dolar b)
        {
            bool retorno = false;
            if (((Dolar)a)._valor == b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro a, Dolar b)
        {
            bool retorno = false;
            if (((Dolar)a)._valor != b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Dolar a, double b)
        {
            bool retorno = false;
            if (a._valor == b)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar a, double b)
        {
            bool retorno = false;
            if (a._valor != b)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(double a, Dolar b)
        {
            bool retorno = false;
            if (a == b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(double a, Dolar b)
        {
            bool retorno = false;
            if (a != b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Dolar operator ++(Dolar a)
        {
            Dolar retorno = new Dolar(a._valor + 1);
            return retorno;
        }

        public static Dolar operator --(Dolar a)
        {
            Dolar retorno = new Dolar(a._valor - 1);
            return retorno;
        }
    }
}
