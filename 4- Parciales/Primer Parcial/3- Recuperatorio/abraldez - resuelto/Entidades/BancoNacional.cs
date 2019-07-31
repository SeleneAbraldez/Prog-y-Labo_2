using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoNacional : Banco
    {
        #region Atributos
        public string pais;
        #endregion

        #region Constructores
        public BancoNacional(string nombre, string pais) : base(nombre)
        {
            this.pais = pais;
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}", this.nombre);
            return sb.ToString();
        }

        public override string Mostrar(Banco b)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(b.Mostrar());
            sb.AppendFormat(" - Pais : {0}", ((BancoNacional)b).pais);
            return sb.ToString();
        }
        #endregion
    }
}
