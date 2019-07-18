using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Moto:VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores.Colores color, short cilindrada): base(cantidadRuedas, cantidadPuertas, color)
        { 
            
        }
    }
}
