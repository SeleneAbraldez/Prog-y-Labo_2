using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    interface IGuardar<T,V>
    {
        public bool Guardar(T obj);
        public V Leer();
    }
}
