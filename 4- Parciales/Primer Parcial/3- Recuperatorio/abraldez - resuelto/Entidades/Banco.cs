using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public abstract class Banco
    {
        #region Atributos   
        public string nombre;
        #endregion

        #region Constructores
        public Banco(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        public abstract string Mostrar();

        public abstract string Mostrar(Banco b);
        #endregion

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is BancoMunicipal)
            {
                MessageBox.Show("Banco Municipal");
            }
            else if (obj is BancoProvincial)
            {
                MessageBox.Show("Banco Provincial");
            }
            else if (obj is BancoNacional)
            {
                MessageBox.Show("Banco Nacional");
            }
            if (obj is Banco)
            {
                if (this.nombre == ((Banco)obj).nombre)
                {
                    MessageBox.Show("Banco, son iguales");
                    retorno = true;
                }
                else
                {
                    MessageBox.Show("Banco, no son iguales");
                }
            }
            else
            {
                MessageBox.Show("No es ningun tipo de banco");
            }
            return retorno;
        }

    }
}
