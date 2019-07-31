using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoProvincial : BancoNacional
    {
        #region Atributos
        public string provincia;
        #endregion

        #region Constructores
        public BancoProvincial(BancoNacional nacional, string provincia) : base(nacional.nombre, nacional.pais)
        {
            this.provincia = provincia;
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre : {0}", this.nombre);
            return sb.ToString();
        }

        public override string Mostrar(Banco b)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(b.Mostrar());
            sb.AppendFormat(" - Provincia : {0}", ((BancoProvincial)b).provincia);
            return sb.ToString();
        }
        #endregion
    }
}
