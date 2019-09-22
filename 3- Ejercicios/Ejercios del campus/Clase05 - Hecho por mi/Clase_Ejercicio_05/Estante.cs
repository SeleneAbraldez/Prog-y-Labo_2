using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Ejercicio_05
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            string retorno = "---Estante - Ubicacion: " + e.ubicacionEstante + "---\n";
            for (int i = 0; i < e.productos.Length; i++)
            {
                retorno += Producto.MostrarProducto(e.productos[i]) + "\n";
            }
            return retorno;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            foreach (Producto c in e.productos)
            {
                if (c == p)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);

        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;

            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (Object.Equals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        retorno = true;
                        break;
                    }
                }
                if (retorno == false)
                {
                    Console.WriteLine("ERROR - No hay mas lugar vacio para gregar producto!");
                }
            }
            else
            {
                Console.WriteLine("ERROR - Producto ya se encuentra en el estante!");
            }
            return retorno;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        Console.WriteLine("Se ha borrado el producto con exito!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR - El producto no se encuentra en el estante para ser borrado!");
            }
            return e;
        }
    }
}
