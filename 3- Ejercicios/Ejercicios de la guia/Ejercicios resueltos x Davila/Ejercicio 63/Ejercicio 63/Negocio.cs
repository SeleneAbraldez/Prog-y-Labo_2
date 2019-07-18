using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_63
{
    class Negocio
    {
        List<string> clientes;
        Caja c1;
        Caja c2;

        public List<String> Clientes 
        {
            get
            {
                return this.clientes;
            }            
        }

        public Caja Caja1 
        { 
            get
            {
                return this.c1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return this.c2;
            }
        }

        public Negocio(Caja c1, Caja c2)
        {
            this.clientes = new List<string>();
            this.c1 = c1;
            this.c2 = c2;
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (string cliente in this.clientes)
            {
                if (c1.FilaClientes.Count <= c2.FilaClientes.Count)
                {
                    c1.FilaClientes.Add(cliente);
                }
                else
                {
                    c2.FilaClientes.Add(cliente);
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine("Cajas Asignadas");

        }

    
    }
}
