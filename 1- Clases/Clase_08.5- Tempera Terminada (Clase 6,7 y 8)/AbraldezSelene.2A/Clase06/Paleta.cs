using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Paleta
    {
        #region Atributos
        private Tempera[] _temperas;
        private int _cantMaxima;
        #endregion

        #region Propiedades
        public Tempera[] misTemperas {
            get 
            {
                return _temperas;
            }
            set
            {
                _temperas = value;
            }
        }
        #endregion

        #region Constructores
        public Paleta() : this(5)
        {
        }

        public Paleta(int cantMax)
        {
            this._cantMaxima = cantMax;
            this._temperas = new Tempera[cantMax];
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            string auxiliar = "";
            int i = 1; //lo uso para decorativo
            foreach (Tempera temp in this._temperas)
            {
                auxiliar += i + "- " + Tempera.Mostrar(temp) + "\n";
                i++;
            }
            return "// Temperas: \n" + auxiliar + "// Cantidad Maxima: " + this._cantMaxima.ToString();

        }

        private int ObtenerIndice() //obtiene el indice VACIO
        {
            for (int i = 0; i < this._cantMaxima; i++)
            {
                if (Equals(null, this._temperas[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion

        #region Sobrecargas
        public static bool operator ==(Paleta pal, Tempera temp)
        {
            foreach (Tempera tempera in pal._temperas)
            {
                if (tempera == temp)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Paleta pal, Tempera temp)
        {
            return !(pal == temp);
        }

        public static Paleta operator +(Paleta pal, Tempera temp) //suma una tempera al lugar vacio de la paleta si no hay nigina igual
        {
            if (pal != temp)
            {
                int indice = pal.ObtenerIndice();
                if(indice != -1)
                {
                    pal._temperas[indice] = temp;
                }
            }
            return pal;
        }

        public static Paleta operator -(Paleta pal, Tempera temp)
        {
            for (int i = 0; i<pal._cantMaxima; i++)
            {
                if (pal.misTemperas[i] == temp)
                {
                    pal.misTemperas[i] = null;
                    break;
                }
            }
            return pal;
        }

        public static implicit operator Paleta(int cant)
        {
            Paleta paleta = new Paleta(cant);
            return paleta;
        }

        public static explicit operator string(Paleta pale)
        {
            return pale.Mostrar();
        }
        #endregion
    }
}
