using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        public static string DecimalBinario(double num) {
            string retorno = "";
            bool flag = false;
            while (num > 0)
            {
                flag = true;
                if (num % 2 == 0)
                {
                    retorno = "0" + retorno;
                }
                else
                {
                    retorno = "1" + retorno;
                }

                num = (int) num / 2;
            }

            if (flag == false)
            {
                retorno = "0";
            }

            return retorno;        
        }

        public static double BinarioDecimal(string binario)
        {
            double retorno = 0;
            double num;
            for(int i = binario.Length-1, j = 0; i >= 0; i--, j++)
            {
                double.TryParse(binario[i].ToString(), out num);
                retorno = retorno + num * Math.Pow(2, j);                
            }

            return retorno;
        }


    }
}
