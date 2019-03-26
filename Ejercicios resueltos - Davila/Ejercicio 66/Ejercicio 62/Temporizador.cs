using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_62
{
    class Temporizador
    {
        public delegate void encargadoTiempo();
        public event encargadoTiempo EventoTiempo;

        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            {
                bool retorno = false; //Si es null o si no está vivo
                if (hilo != null && hilo.IsAlive == true)
                {
                    retorno = true;
                }
                return retorno;
            }
            set 
            {
                if ((value == true && hilo == null) || (value = true && hilo != null && hilo.IsAlive == false))
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
                else if (value == false && hilo != null && hilo.IsAlive == true)
                {
                    hilo.Abort();
                }
            }
        }

        public Temporizador(int intervalo)
        {
            this.Intervalo = intervalo;
        }

        public int Intervalo 
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            } 
        }

        private void Corriendo()
        {
            while (true)
            {
                EventoTiempo();
                Thread.Sleep(this.Intervalo);
            }
        }
    }
}
