using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17 {
    class Boligrafo {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        //
        public ConsoleColor GetColor() {
            return color;
        }

        public short GetTinta() {
            return tinta;
        }

        private void setTinta(short tinta) {
            if ((this.tinta + tinta) <= Boligrafo.cantidadTintaMaxima && (this.tinta + tinta) >= 0) {
                this.tinta = tinta;
            }
        }

        public bool Pintar(int gasto, out string dibujo) {
            dibujo = "";
            if (gasto <= tinta) {
                tinta = (short)(tinta - (short)gasto);
                for (int i = 0; i < gasto; i++) {
                    dibujo = dibujo + "*";
                }
                return true;
            } else {
                dibujo = "No hay tinta suficiente!";
                return false;
            }
        }

        public void Recargar() {
            setTinta(cantidadTintaMaxima);
        }

        //
        public Boligrafo(short tinta, ConsoleColor color) {
            this.tinta = tinta;
           Console.ForegroundColor = color;
        }

    }
}
