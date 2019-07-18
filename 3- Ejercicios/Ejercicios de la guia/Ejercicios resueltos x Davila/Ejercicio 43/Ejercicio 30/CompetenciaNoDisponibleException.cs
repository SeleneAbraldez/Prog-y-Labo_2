using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class CompetenciaNoDisponibleException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get { return this.nombreClase; }
        }
        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo):this(mensaje,clase,metodo,null)
        {
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            :base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Excepción en el método {0} de la clase {1}: ", this.NombreMetodo, this.NombreClase);
            retorno.AppendLine(this.Message);
            Exception e = this.InnerException;
            do
            {
                retorno.AppendLine(e.Message);
                e = this.InnerException;
            } while (!ReferenceEquals(e.InnerException, null));
            return retorno.ToString();
        }
    }
}
