using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int _tinta;

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this._color = color;
            if (tinta <= 100)
            {
                this._tinta = tinta;
            }
            else if (tinta > 100)
            {
                this._tinta = 100;
            }
            else
            {
                this._tinta = 0;
            }
        }

        public bool Pintar(int gasto)
        {
            bool retorno = false;

            if(this._tinta >= gasto)
            {
                Console.ForegroundColor = this._color;
                this._tinta = this._tinta - gasto;
                retorno = true;
            }

            return retorno;
        }

        public void Recargar()
        {
            this._tinta = 100;
        }

        public ConsoleColor getColor()
        {
            return this._color;
        }

        public int getTinta()
        {
            return this._tinta;
        }
    }
}
