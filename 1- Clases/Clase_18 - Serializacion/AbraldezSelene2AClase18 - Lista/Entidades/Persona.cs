using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Persona : Humanx, InterfaceSeriXML
    {
        #region Atributos
        public string nombre;
        public string apellido;
        InterfaceSeriXML serializable;
        #endregion

        #region serializable
        public string Propiedad { get => serializable.Propiedad; set => serializable.Propiedad = value; }

        public bool SerializarXML()
        {
            return serializable.SerializarXML();
        }

        public bool DeserializarXML()
        {
            return serializable.DeserializarXML();
        }

        
        #endregion

        #region Metodos
        #region Contructores
        public Persona()
        {
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

        #region Sobreescritura
        public override string ToString()
        {
            return (this.nombre + " " +this.apellido + ", DNI: " + base.ToString());
        }
        #endregion
        #endregion
    }
}
