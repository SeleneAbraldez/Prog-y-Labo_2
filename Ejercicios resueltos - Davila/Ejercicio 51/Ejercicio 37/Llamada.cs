using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    abstract public class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas }
        
        #region Atributos
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region Propiedades
        public float Duracion { get{return this._duracion;} }
        public string NroDestino { get { return this._nroDestino; } }
        public string NroOrigen { get { return this._nroOrigen; } }
        public abstract float CostoLlamada { get;}

        #endregion

        #region Metodos
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendFormat("\nDuracion: {0}", this.Duracion);
            salida.AppendFormat("\nNumero Destino: {0}", this.NroDestino);
            salida.AppendFormat("\nNumero Origen: {0}", this.NroOrigen);

            return salida.ToString();       
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion > llamada2.Duracion)
                retorno = 1;
            else if (llamada1.Duracion < llamada2.Duracion)
                retorno = -1;
            return retorno;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen);
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        #endregion 
    }
}
