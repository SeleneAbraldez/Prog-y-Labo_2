using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    class GuardarTexto<T, V> : IGuardar<T, V>
    {
        public bool Guardar(T obj) 
        {
            return true;
        }

        public V Leer() 
        {
            string texto = "Texto Leído";
            return (V)Convert.ChangeType(texto, typeof(V));        
        }
    }
}
