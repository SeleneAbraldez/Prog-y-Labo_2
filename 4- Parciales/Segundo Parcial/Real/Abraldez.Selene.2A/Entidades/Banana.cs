using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banana : Fruta
    {
        protected string _paisOrigen;

        public string Nombre
        {
            get { return "Banana"; }
        }
        public string Pais
        {
            get { return this._paisOrigen; }
            set { this._paisOrigen = value; }
        }

        public override bool TieneCarozo
        {
            get { return false; }
        }


        public Banana(string color, double peso, string pais) : base(color, peso)
        {
            this.Pais = pais;
        }

        protected override string FrutasToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutasToString());
            sb.AppendFormat("Pais de origen: {0}", this.Pais);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutasToString();
        }
    }
}
