using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    class Serializar<S,V> : IGuardar<S,V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            string texto = "Objeto Leído";
            return (V)Convert.ChangeType(texto, typeof(V));
        }
    }
}
