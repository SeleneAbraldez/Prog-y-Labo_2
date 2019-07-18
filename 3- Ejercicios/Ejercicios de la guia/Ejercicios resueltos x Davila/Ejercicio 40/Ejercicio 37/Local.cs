using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Local:Llamada
    {
        protected float _costo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public Local(Llamada llamada, float costo) :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) :base(duracion,destino,origen)
        {
            this._costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendLine(base.Mostrar());
            salida.AppendFormat("\nCosto: {0}", this.CostoLlamada);

            return salida.ToString();  
        }

        private float CalcularCosto()
        {
            float costo = this._costo * this.Duracion;
            return costo;
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
