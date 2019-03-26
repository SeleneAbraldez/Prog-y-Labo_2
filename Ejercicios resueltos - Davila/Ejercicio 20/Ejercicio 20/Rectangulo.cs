using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        public float area;
        public float lado;
        public float perimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            float rBase = Math.Abs(vertice1.getX() - vertice3.getX());
            float rAltura = Math.Abs(vertice1.getY() - vertice3.getY());




        }
    }
}
