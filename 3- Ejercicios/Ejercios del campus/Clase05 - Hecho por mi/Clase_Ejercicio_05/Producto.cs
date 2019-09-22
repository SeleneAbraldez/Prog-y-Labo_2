using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Ejercicio_05
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        //Metodos
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            return p.codigoDeBarra + " " + p.marca + " " + p.precio.ToString();
        }
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;
            if (p.marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if(!Object.Equals(p1, null) && !Object.Equals(p2, null)){
                if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    retorno = true;
                }
            }        
            return retorno;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator string(Producto p)
        {
            string retorno;
            retorno = p.codigoDeBarra;
            return retorno;
        }
    }
}
