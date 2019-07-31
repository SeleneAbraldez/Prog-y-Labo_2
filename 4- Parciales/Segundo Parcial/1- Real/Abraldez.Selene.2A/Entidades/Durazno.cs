using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public string Nombre
        {
            get { return "Durazno"; }
        }
        public int Pelusa
        {
            get { return this._cantPelusa; }
            set { this._cantPelusa = value; }
        }

        public override bool TieneCarozo
        {
            get { return true; }
        }


        public Durazno(string color, double peso, int pelusa) : base(color, peso)
        {
            this.Pelusa = pelusa;
        }

        protected override string FrutasToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutasToString());
            sb.AppendFormat("Cantidad de pelusa: {0}", this.Pelusa);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutasToString();
        }
    }
}
