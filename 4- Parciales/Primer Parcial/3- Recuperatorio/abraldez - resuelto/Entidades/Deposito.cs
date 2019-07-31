using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito
    {
        #region Atributos
        public List<Producto> productos;
        #endregion

        #region Constructores
        /// Constructor por defecto (cant 3)
        public Deposito() : this(3)
        {
        }

        /// <param name="cant">Cantidad de productos a inicializar</param>
        public Deposito(int cant)
        {
            productos = new List<Producto>(cant);
        }
        #endregion

        #region Sobrecarga de operadores
        public static List<Producto> operator +(Deposito d1, Deposito d2)
        {
            List<Producto> suma = d1.productos;

            foreach (Producto prod2 in d2.productos)
            {
                if (suma.Contains(prod2))
                {
                    foreach (Producto prod1 in suma)
                    {
                        if (prod1.nombre == prod2.nombre)
                        {
                            prod1.stock += prod2.stock;
                        }
                    }
                }
                else
                {
                    suma.Add(prod2);
                }
            }
            return suma;
        }
        #endregion

        public static void OrdenarAscendente(Deposito d1)
        {
            d1.productos.Sort((p1, p2) => p1.stock.CompareTo(p2.stock));
        }
        public static void OrdenarAlfabetico(Deposito d1)
        {
            d1.productos.Sort((p1, p2) => string.Compare(p1.nombre, p2.nombre));
        }

    }
}
