using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_21
{
    public class Pesos
    {
        const double factorConversion = 17.55;
        double _valor;

        public Pesos(double valor)
        {
            this._valor = valor;
        }

        public Pesos()
        {
            this._valor = 0;
        }

        public double getValor()
        {
            return this._valor;
        }

        public static explicit operator Pesos(Dolar a)
        {
            Pesos retorno = new Pesos(a.getValor() * factorConversion);
            return retorno;
        }

        public static explicit operator Pesos(double a)
        {
            Pesos retorno = new Pesos(a);
            return retorno;
        }
    }
}
