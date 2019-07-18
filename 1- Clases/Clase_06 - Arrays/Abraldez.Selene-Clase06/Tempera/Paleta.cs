using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06
{
    public class Paleta
    {
        #region Atributos
        private Tempera[] _temperas;
        private int _cantidadMaxima;
        #endregion

        public Tempera[] _MisTemperas
        {
            get { return _temperas; }
        }

        #region Contructores
        public Paleta() : this(5)
        {
        }

        public Paleta(int cant)
        {
            this._cantidadMaxima = cant;
            this._temperas = new Tempera[cant];
        }
        #endregion

        #region Metodos
        public static implicit operator Paleta(int cantM)
        {
            Paleta paletita = new Paleta(cantM);
            return paletita;
        }

        private string Mostrar()
        {
            string auxiliar = "";
            int i = 1;
            foreach (Tempera temp in this._temperas)
            {
                auxiliar +=  i + "- " + Tempera.Mostrar(temp) + "\n";
                i++;
            }
            return "// Temperas: \n" + auxiliar + "// Cantidad Maxima: " + this._cantidadMaxima.ToString();
        }

        public static explicit operator string(Paleta paletita)
        {
                return paletita.Mostrar();
        }

        private int ObtenerIndice() //obtener indice vacio
        {
            for (int i = 0; i>this._cantidadMaxima; i++){
                if (object.Equals(null, this._temperas[i]))
                {
                    return i;
                }     
            }
            return -1;
        }

        #endregion

        #region Sobrecarga
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
            if (!(pal == temp))
            {
                int indice = pal.ObtenerIndice();
                if (indice!=-1)
                {
                    pal._temperas[indice] = temp;
                }
            }
            return pal;
        }
        #endregion
    }
}
