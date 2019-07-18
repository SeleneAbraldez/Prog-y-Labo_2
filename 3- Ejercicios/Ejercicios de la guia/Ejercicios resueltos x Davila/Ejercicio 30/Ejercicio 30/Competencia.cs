using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
            this.cantidadCompetidores = 0;
            this.cantidadVueltas = 0;
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string mostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            for(int i = 0; i < this.competidores.Count; i++)
            {
                datos.Append(this.competidores[i].mostrarDatos());
            }

            return datos.ToString();
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if (c.competidores.Contains(a))
            {
                retorno = true;
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
                a.CantidadCombustible = 0;
                c.competidores.Remove(a);
            }

            return retorno;

        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            Random cantidadCombustible = new Random();

            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                retorno = true;
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)cantidadCombustible.Next(15, 100);
                c.competidores.Add(a);
            }

            return retorno;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            foreach (AutoF1 auto in c.competidores)
            {
                if(auto == a)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }



    }
}
