using System;

namespace Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private eTipoTinta _tipoTinta;

        #region constructores
        public Tinta() : this(ConsoleColor.Black, eTipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor color) : this(color, eTipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor color, eTipoTinta tipoTinta)
        {
            this._tipoTinta = tipoTinta;
            this._color = color;
        }
        #endregion

        private string Mostrar()
        {
            return "Color: " + this._color.ToString() + ", Tipo de Tinta: " + this._tipoTinta.ToString();
        }

        public static string Mostrar(Tinta escrito)
        {
            return escrito.Mostrar(); 
        }

        public static bool operator == (Tinta bolig1, Tinta bolig2) {
            bool retorno = false;
            if (bolig1._color == bolig2._color && bolig1._tipoTinta == bolig2._tipoTinta){
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Tinta bolig1, Tinta bolig2)
        {
            return !(bolig1 == bolig2);
        }


        public static bool operator == (Tinta bolig, ConsoleColor color)
        {
            bool retorno = false;

            if (bolig._color == color){
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Tinta bolig, ConsoleColor color){
            return !(bolig == color);
        }
    }
}
