using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract public class Fruta
    {
        protected string _color;
        protected double _peso;

        public abstract bool TieneCarozo { get; }

        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }
        public double Peso
        {
            get { return this._peso; }
            set { this._peso = value; }
        }

        public Fruta()
        {
        }

        public Fruta(string color, double peso)
        {
            this.Color = color;
            this.Peso = peso;
        }

        protected virtual string FrutasToString()
        {
            return string.Format("Color: {0} Peso: {1}", this.Color, this.Peso);
        }
    }
}
