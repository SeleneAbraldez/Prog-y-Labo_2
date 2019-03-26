using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        public Centralita() 
        {        
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendFormat("\nRazon Social: {0}", this.razonSocial);
            salida.AppendFormat("\nGanancia Total: {0}", this.GananciasPorTotal);
            salida.AppendFormat("\nGanancia Local: {0}", this.GananciasPorLocal);
            salida.AppendFormat("\nGanancia Provincial: {0}", this.GananciasPorProvincial);
            salida.Append("\nLLAMADAS:");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                salida.Append("\n---------------------------------------");
                salida.Append(llamada.Mostrar());
            }

            return salida.ToString();
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach(Llamada llamada in this.listaDeLlamadas)
            {
                switch (tipo)
                { 
                    case Llamada.TipoLlamada.Local:
                        if(llamada is Local)
                        {
                            ganancia = ganancia + ((Local)llamada).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            ganancia = ganancia + ((Local)llamada).CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                        }

                        break;
                }
            }

            return ganancia;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }
}
