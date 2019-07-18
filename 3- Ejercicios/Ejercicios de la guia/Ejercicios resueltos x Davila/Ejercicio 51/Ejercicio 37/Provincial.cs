using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class Provincial:Llamada,IGuardar<string>
    {
        public enum Franja { Franja_1, Franja_2, Franja_3}

        protected Franja _franjaHoraria;
        private string rutaDeArchivo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }
        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
            }
        }

        public Provincial(Llamada llamada, Franja miFranja) 
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,miFranja)
        {
        }

        public Provincial(string origen, float duracion, string destino, Franja miFranja)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
        }

        protected override string Mostrar()        
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendLine(base.Mostrar());
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

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }
    }
}
