using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria {
    class Punto {
        private int x;
        private int y;

        public int GetX() {
            return x;
        }
        public int GetY() {
            return y;
        }
        public Punto(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }

    class Rectangulo {
        float area;
        float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        public float Area() {

        }
        
        public float Perimetro() {

        }

        public Rectangulo(Punto vertice1, Punto vertice3) {

        }

    }
}
