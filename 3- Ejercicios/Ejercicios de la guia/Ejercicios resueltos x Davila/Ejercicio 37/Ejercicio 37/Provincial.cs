using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Provincial:Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3}

        protected Franja _franjaHoraria;

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        public Provincial(Llamada llamada, Franja miFranja) 
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,miFranja)
        {
        }

        public Provincial(string origen, float duracion, string destino, Franja miFranja)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
        }

        public string Mostrar()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendFormat("\nDuracion: {0}", this.Duracion);
            salida.AppendFormat("\nNumero Destino: {0}", this.NroDestino);
            salida.AppendFormat("\nNumero Origen: {0}", this.NroOrigen);
            salida.AppendFormat("\nFranja Horaria: {0}", this._franjaHoraria);
            salida.AppendFormat("\nCosto: {0}", this.CostoLlamada);

            return salida.ToString();  
        }

        private float CalcularCosto()
        {
            float costo = 0;
            float retorno;

            switch (this._franjaHoraria)
            { 
                case Franja.Franja_1:
                    costo = (float)0.99;
                    break;
                case Franja.Franja_2:
                    costo = (float)1.25;
                    break;
                case Franja.Franja_3:
                    costo = (float)0.66;
                    break;
            }
             retorno = costo * this.Duracion;
            return retorno;
        }
    }
}
