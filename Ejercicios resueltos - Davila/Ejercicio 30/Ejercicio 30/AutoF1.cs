using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }
        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }

        public AutoF1(short numero, string escuderia)
        {
            this.CantidadCombustible = 0;
            this.EnCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
            this.VueltasRestantes = 0;
        }

        public string mostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("\n---------------------------------------");
            datos.AppendFormat("\nNumero: {0}", this.numero);
            datos.AppendFormat("\nEscuderia: {0}", this.escuderia);
            datos.AppendFormat("\n¿En competencia?: {0}", this.EnCompetencia);
            datos.AppendFormat("\nCantidad Combustible: {0}", this.CantidadCombustible);
            datos.AppendFormat("\nVueltas Restantes: {0}", this.VueltasRestantes);

            return datos.ToString();
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if(a1.numero == a2.numero && a1.escuderia == a2.escuderia)
            {
                retorno = true;
            }

            return retorno;
        }

    }
}
