using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private sbyte _cantidad;

        public Tempera(ConsoleColor colorcito, string marquita, sbyte cantidad)
        {
            this._color = colorcito;
            this._marca = marquita;
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            return this._cantidad.ToString() + "-" + this._color.ToString() + "-" + this._marca.ToString();
        }

        public static string Mostrar(Tempera cosa)
        {
            string retorno = "";
            if (cosa != null) //Si la tempera pasada es null (no tiene nada)
            {
                retorno = cosa.Mostrar(); //Nos retornara la string cargada de mostrar

            }
            return retorno;

        }


        //Compara dos temperas / Si son nulas o si tienen los mismos valores en sus atributos.
        public static bool operator ==(Tempera parametro1, Tempera parametro2)
        {
            bool retorno = false;
            if ((Object.Equals(parametro1, null)) && (Object.Equals(parametro2, null)))
            { //si tempera 1 y tempera 2 son nulas

                retorno = true;
                //retorno true
            }
            else if (Object.Equals(parametro1, null) || (Object.Equals(parametro2, null)))
            {// si uno de los dos no es null
                retorno = false;
                // solo son iguales cuando los dos son distintos de null
            }
            else
            {
                if (parametro2._color == parametro1._color && parametro2._marca == parametro1._marca)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;

        }


        public static bool operator !=(Tempera parametro1, Tempera parametro2)
        {
            return !(parametro1 == parametro2);
        }


        public static Tempera operator +(Tempera cantidad, sbyte cantidadDeNuevo)
        {
            cantidad._cantidad += cantidadDeNuevo;
            return cantidad;
        }


        public static Tempera operator +(Tempera cosa1, Tempera cosa2)
        {
            if (cosa1 == cosa2)
            {
                cosa1 += cosa2._cantidad;
                //cosa1 = cosa1 + cosa2._cantidad; //Es lo mismo que la de arriba
            }
            return cosa1;
        }


        public static implicit operator sbyte(Tempera miTempera)//reciben dos parametros
        {
            return miTempera._cantidad;
        }

        public static implicit operator ConsoleColor(Tempera miTempera)//reciben dos parametros
        {
            return miTempera._color;
        }

        public static implicit operator string(Tempera miTempera)//reciben dos parametros
        {
            return miTempera._marca;
        }
    }
}
