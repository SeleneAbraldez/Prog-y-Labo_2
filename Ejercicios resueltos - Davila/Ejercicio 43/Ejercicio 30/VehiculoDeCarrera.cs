using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #region propiedades
        public bool EnCompetencia { 
            get
            {
                return this.enCompetencia;
            }
            set
            { 
                this.enCompetencia = value; 
            }
        }
        public short VueltasRestantes { 
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value; 
            }
        }
        public short CantidadCombustible {
            get{
                return this.cantidadCombustible; 
            }
            set{
                this.cantidadCombustible = value;
            }
        }
        public string Escuderia { 
            get{
                return this.escuderia;
            }
            set{
                escuderia = value;
            }
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        #endregion 
        
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public string mostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("\nNumero: {0}", this.Numero);
            datos.AppendFormat("\nEscuderia: {0}", this.Escuderia);
            datos.AppendFormat("\n¿En competencia?: {0}", this.EnCompetencia);
            datos.AppendFormat("\nCantidad Combustible: {0}", this.CantidadCombustible);
            datos.AppendFormat("\nVueltas Restantes: {0}", this.VueltasRestantes);

            return datos.ToString();
        }


        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }

        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            bool retorno = false;
            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
