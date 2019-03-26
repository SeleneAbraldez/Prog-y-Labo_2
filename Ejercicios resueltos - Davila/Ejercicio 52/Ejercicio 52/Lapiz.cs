using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public ConsoleColor Color
        {
            get 
            {
                return ConsoleColor.Gray;    
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set 
            {
                this.tamanioMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto) 
        {
            this.UnidadesDeEscritura = this.UnidadesDeEscritura - 0.1f * texto.Length;
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String.Format("Lapiz, Color: {0}, Tamaño Mina: {1}",this.Color,this.UnidadesDeEscritura);
        }
    }
}
