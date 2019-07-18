using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
    class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }               
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) :this()
        {
            this.puesto = puesto;
        }
        
        public bool Atender(Cliente cli)
        {
            bool retorno = false;
            if (cli != null)
            {
                Thread.Sleep(1500);
                retorno = true;
            }

            return retorno;
        }


    }
}
