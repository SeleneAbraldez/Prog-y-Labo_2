using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class Local:Llamada,IGuardar<string>
    {
        #region Atributos
        protected float _costo;
        private string rutaDeArchivo;
        #endregion

        #region Propiedades
        public override float CostoLlamada 
        { 
            get 
            {
                return this.CalcularCosto();
            } 
        }

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
        #endregion

        #region Constructores
        public Local(Llamada llamada, float costo) :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) :base(duracion,destino,origen)
        {
            this._costo = costo;
        }
        #endregion

        #region Métodos
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

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
