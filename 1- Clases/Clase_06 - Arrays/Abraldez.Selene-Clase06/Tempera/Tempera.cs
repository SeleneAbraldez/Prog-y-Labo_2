using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06
{
    public class Tempera
    {
        #region Atributos
        private ConsoleColor _color;
        private string _marca;
        private sbyte _cantidad;
        #endregion



        #region Contructor
        public Tempera(ConsoleColor color, string marca, sbyte cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            return "Marca: " + this._marca + " - Cantidad: " + this._cantidad.ToString() + " - Color: " + this._color.ToString();
        }

        public static string Mostrar(Tempera temp)
        {
            //string retorno = "";
            //if(temp != null){
            //    retorno = temp.Mostrar();
            //} else{
            //    retorno = "Tempera es nula. ";
            //}
            //return retorno;
            string retorno = "";
            if (temp != null) //Si la tempera pasada es null (no tiene nada)
            {
                retorno = temp.Mostrar(); //Nos retornara la string cargada de mostrar

            }
            return retorno;
        }
        #endregion

        #region Sobrecarga 
        public static bool operator ==(Tempera temp1, Tempera temp2)
        {
            if ((object.Equals(null, temp1) && object.Equals(null, temp2)))
            {
                return true;
            } else
            {
                if ((object.Equals(null, temp1) || object.Equals(null, temp2)))
                {
                    return false;
                }
                else if (temp1._color == temp2._color && temp1._marca == temp2._marca)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);
        }

        public static Tempera operator +(Tempera temp1, sbyte sumar)
        {
            temp1._cantidad += sumar;
            return temp1;
        }

        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {
            if (temp1 == temp2)
            {
                temp1 += temp2._cantidad;
            }
            return temp1;
        }

        public static implicit operator sbyte (Tempera temp1)
        {
            return temp1._cantidad;
        }
        #endregion
    }
}
