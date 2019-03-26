using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;

            string nBinario = objBinario + objDecimal;
            double nDecimal = objDecimal + objBinario;
            
            Console.WriteLine("{0}\n {1}\n",nBinario,nDecimal);

            nBinario = objBinario - objDecimal;
            nDecimal = objDecimal - objBinario;

            Console.WriteLine("{0}\n {1}\n", nBinario, nDecimal);



            Console.ReadKey();
        }
    }
}
