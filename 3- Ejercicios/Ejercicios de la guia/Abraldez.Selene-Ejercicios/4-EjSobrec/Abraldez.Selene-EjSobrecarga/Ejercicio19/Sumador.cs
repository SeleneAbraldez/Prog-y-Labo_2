using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        #region atributos
        int cantidadSumas;
        #endregion

        #region constructores
        public Sumador(int cantS)
        {
            this.cantidadSumas = cantS;
        }

        public Sumador() : this(0)
        {
        }
        #endregion

        #region metodos
        public long Sumar(long a, long b)
        {
            //Console.WriteLine(cantidadSumas);
            cantidadSumas += 1;
            //Console.WriteLine(cantidadSumas);
            return (a+b);
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas += 1;
            return (a + b);
        }

        #region operadores

        #endregion

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas + s2.cantidadSumas);
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

    }
}
