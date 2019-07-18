using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06
{
    public class Paleta
    {
        private Tempera[] _temperas;//Como un vector
        private int _cantidadMaxima; //La cantidad maxima

        private Paleta(int cantidad)
        {
            this._temperas = new Tempera[cantidad]; //Si es un array tengo que crear un new objecto
            this._cantidadMaxima = cantidad;
        }

        private Paleta() : this(5)//cantidad maxima 5
        {

        }

        private Tempera[] myTempera; //Definimos un set y get llamado myTempera

        public Tempera[] myTemperas
        {
            get { return _temperas; }
            set { _temperas = value; }
        }


        //Generar sobrecarga del implicit Paleta

        public static implicit operator Paleta(int entero) //Se definiria paleta(cantidadPasada)
        {
            Paleta objeto = new Paleta(entero); //Creamos nueva paleta con los enteros que le pasamos y retornamos esa paleta creada
            return objeto;
        }

        private string Mostrar() //Nos muestra la paleta
        {
            string aux = "";
            foreach (Tempera auxiliar in this._temperas) //Con el foreach, en el auxilar se le almacena las this.temperas
            {
                aux =aux + ""+ Tempera.Mostrar(auxiliar); //Se van cargando todas y se van mostrando
            }

            return "Cantidad " + this._cantidadMaxima.ToString() + "-" + aux; //Retornamos la cantidad maxima y las temperas cargadas
        }

        public static explicit operator string(Paleta miPaleta)//Nos muestra la paleta que le pasamos como parametro
        {
            return miPaleta.Mostrar(); //Reutilizamos codigo
        }

        public static bool operator ==(Paleta paletaUno, Tempera temperaUno) //Verificamos que la tempera que pasamos este en la paleta
        {
                bool retorno = false;
                for (int i = 0; i < paletaUno._cantidadMaxima; i++) //Recorro la cantidad maxima de paletas
                {
                    if (paletaUno._temperas[i] == temperaUno) //Si coincide la tempera que esta en la paleta con la tempera pasada devuelve true
                    {
                        retorno = true;
                    }
                }
                return retorno;
        }

        public static bool operator !=(Paleta paletaUno, Tempera temperaUno)
        {
            return !(paletaUno == temperaUno); 
            
        }

        private int ObtenerIndice()
        {
            int indice = -1; //Declaramos una variable indice que devuelve -1 si no funciona
            int i = -1;

            foreach (Tempera t in _temperas) //Recorremos todas las temperas y tomamos el valor en t
            {
                i++;  //Se va incrementando
                if (object.Equals(t, null)) //Comprobamos que parte del vector es null 
                {
                    indice = i;//Si es true, nos devolvera el indice que se encontro
                    break; //Si no le pongo el break seguira iterando
                }
            }

            return indice;

        }
        public static Paleta operator +(Paleta paletaUno, Tempera temperaUno)
        {
            if (!(paletaUno == temperaUno))//Si no coindicen, se agregan
            {
                paletaUno._temperas[paletaUno.ObtenerIndice()] = temperaUno; //De la paleta pasada por prametro, llamamos a la funcion obtener indice para que nos devuelva un indice con null y lo rellenemos con la tempera pasada como parametro
            }
            return paletaUno; //Retornamos la peleta cargada
        }

    }
}
