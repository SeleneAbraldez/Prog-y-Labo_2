using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Tempera
    {
        #region Atributos
        private ConsoleColor _color;
        private string _marca;
        private sbyte _cantidad;
        #endregion

        //#region Propiedades
        //#endregion

        #region Constructores
        public Tempera(ConsoleColor colo, string marc, sbyte cant)
        {
            this._color = colo;
            this._marca = marc;
            this._cantidad = cant;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            return "Marca: " + this._marca + " - Cantidad: " + this._cantidad.ToString() + " - Color: " + this._color.ToString();
        }

        public static string Mostrar(Tempera temp)
        {
            string retorno = "Tempera es nula";
            if (temp != null)
            {
                retorno = temp.Mostrar();
            }
            return retorno;
        }
        #endregion

        #region sobrecargas

        public static bool operator ==(Tempera temp1, Tempera temp2)
        {
            if (Equals(null, temp1) && Equals(null, temp2))
            {
                return true;
            }else if (Equals(null, temp1) || Equals(null, temp2))
            {
                return false;
            }else if (temp1._marca == temp2._marca && temp1._color == temp2._color)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);
        }

        public static Tempera operator +(Tempera temp, sbyte cant)
        {
            temp._cantidad += cant;
            return temp;
        }

        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {
            if (temp1 == temp2)
            {
                temp1 += temp2._cantidad;   //usa la sobrecarga temp+cant
            }
            return temp1;
        }

        public static implicit operator sbyte(Tempera temp) ///los tres tipos de sobrecarga para psar los valores de todo
        {
            return temp._cantidad;
        }
        public static implicit operator ConsoleColor(Tempera temp)
        {
            return temp._color;
        }
        public static implicit operator string(Tempera temp)
        {
            return temp._marca;
        }

        #endregion
    }
}
