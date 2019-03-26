using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get 
            {
                return this.colorTinta;    
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set 
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto) 
        {
            this.UnidadesDeEscritura = this.UnidadesDeEscritura - 0.3f * texto.Length;
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura = this.UnidadesDeEscritura + unidades;
            return true;
        }

        public override string ToString()
        {
            return String.Format("Boligrafo, Color: {0}, Cantidad Tinta: {1}",this.Color,this.UnidadesDeEscritura);
        }
    }
}
