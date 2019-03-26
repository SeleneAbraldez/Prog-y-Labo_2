using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Libro
    {
        List<string> paginas;

        public string this[int i]
        {
            get
            {
                if (i < this.paginas.Count)
                {
                    return this.paginas[i];
                }
                else
                {
                    return "";
                }

            }
            set
            {
                if (i < this.paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else
                {
                    this.paginas.Add(value);
                }                
            }
        }

    }
}
