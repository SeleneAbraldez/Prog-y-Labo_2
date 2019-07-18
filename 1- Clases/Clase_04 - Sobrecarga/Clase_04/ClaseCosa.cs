using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameSpaceClase_04
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        #region Metodos
        #region Mostrar
        public string Mostrar()
        {
            return "Entero: " + this.entero.ToString() + ", Cadena: " + this.cadena + ", Fecha: " + this.fecha.ToString();
        }

        public static string Mostrar(Cosa obj)
        {
            return obj.Mostrar(); //reutilizacion de codigo usando mostrar por medio de cosa
        }
        #endregion 

        //sobrecarga valida por mismo numero de variables, pero distintos tipos
        #region EstablecerValor
        public void EstablecerValor(int num) 
        {
            this.entero = num;
        }
        public void EstablecerValor(string pala)
        {
            this.cadena = pala;
        }
        public void EstablecerValor(DateTime fech)
        {
            this.fecha = fech;
        }
        #endregion

        #endregion

        #region Contructores 
        public Cosa()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(int a) : this()
        {
            this.entero = a;
        }
        public Cosa(int a, DateTime b) : this(a)
        {
            this.fecha = b;
        }
        public Cosa(int a, DateTime b, string c)
        {
            this.entero = a;
            this.fecha = b;
            this.cadena = c;
        }
        #endregion
    }
}
