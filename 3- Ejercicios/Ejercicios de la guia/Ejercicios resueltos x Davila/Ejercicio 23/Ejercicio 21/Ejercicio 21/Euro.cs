using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    public class Euro
    {
        const double factorConversion = 1.3642;
        double _valor;

        public Euro(double valor)
        {
            this._valor = valor;
        }

        public Euro()
        {
            this._valor = 0;
        }

        public double getValor()
        {
            return this._valor;
        }

        public static explicit operator Euro(Dolar a)
        {
            Euro retorno = new Euro(a.getValor() / factorConversion);
            return retorno;
        }

        public static explicit operator Euro(double a)
        {
            Euro retorno = new Euro(a);
            return retorno;
        }

        public static Euro operator +(Euro a, Euro b)
        {
            double newValue = a._valor + b._valor;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static Euro operator +(Euro a, Dolar b)
        {
            double newValue = a._valor + ((Euro)b)._valor;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static Euro operator +(Dolar a, Euro b)
        {
            double newValue = ((Euro)a)._valor + b._valor;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static Euro operator +(Euro a, double b)
        {
            double newValue = a._valor + b;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static Euro operator +(double a, Euro b)
        {
            double newValue = a + b._valor;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static Euro operator -(Euro a, Euro b)
        {
            double newValue = a._valor - b._valor;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static Euro operator -(Euro a, Dolar b)
        {
            double newValue = a._valor - ((Euro)b)._valor;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static Euro operator -(Dolar a, Euro b)
        {
            double newValue = ((Euro)a)._valor - b._valor;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static Euro operator -(Euro a, double b)
        {
            double newValue = a._valor - b;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static Euro operator -(double a, Euro b)
        {
            double newValue = a - b._valor;
            Euro retorno = new Euro(newValue);
            return retorno;
        }

        public static bool operator ==(Euro a, Euro b)
        {
            bool retorno = false;
            if (a._valor == b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro a, Euro b)
        {
            bool retorno = false;
            if (a._valor != b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro a, Dolar b)
        {
            bool retorno = false;
            if (a._valor == ((Euro)b)._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro a, Dolar b)
        {
            bool retorno = false;
            if (a._valor != ((Euro)b)._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Dolar a, Euro b)
        {
            bool retorno = false;
            if (((Euro)a)._valor == b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar a, Euro b)
        {
            bool retorno = false;
            if (((Euro)a)._valor != b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro a, double b)
        {
            bool retorno = false;
            if (a._valor == b)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro a, double b)
        {
            bool retorno = false;
            if (a._valor != b)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(double a, Euro b)
        {
            bool retorno = false;
            if (a == b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(double a, Euro b)
        {
            bool retorno = false;
            if (a != b._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Euro operator ++(Euro a)
        {
            Euro retorno = new Euro(a._valor + 1);
            return retorno;
        }

        public static Euro operator --(Euro a)
        {
            Euro retorno = new Euro(a._valor - 1);
            return retorno;
        }

        
    }
}
