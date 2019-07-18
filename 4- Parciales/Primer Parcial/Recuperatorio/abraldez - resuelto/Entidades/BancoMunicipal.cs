using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoMunicipal : BancoProvincial
    {

        #region Atributos
        public string municipio;
        #endregion

        #region Constructor
        public BancoMunicipal(BancoProvincial provincial, string municipio) : base(new BancoNacional(provincial.nombre, provincial.pais), provincial.provincia)
        {
            this.municipio = municipio;
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
            sb.AppendFormat(" - Municipio : {0}", ((BancoMunicipal)b).municipio);
            return sb.ToString();

        }
        #endregion

        #region Sobrecarga

        public static implicit operator string(BancoMunicipal bM)
        {
            return "Nombre: " + bM.nombre + " - Pais:" + bM.pais + " - Provincia: " + bM.provincia + " - Municipio: " + bM.municipio;
        }

        public override string ToString()
        {
            return this;
        }
        #endregion
    }
}
