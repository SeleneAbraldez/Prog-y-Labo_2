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

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        public Local(Llamada llamada, float costo) :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) :base(duracion,destino,origen)
        {
            this._costo = costo;
        }

        public string Mostrar()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendFormat("\nDuracion: {0}", this.Duracion);
            salida.AppendFormat("\nNumero Destino: {0}", this.NroDestino);
            salida.AppendFormat("\nNumero Origen: {0}", this.NroOrigen);
            salida.AppendFormat("\nCosto: {0}", this.CostoLlamada);

            return salida.ToString();  
        }

        private float CalcularCosto()
        {
            float costo = this._costo * this.Duracion;
            return costo;
        }
    }
}
