using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    interface InterfaceSeriXML
    {
        bool SerializarXML();
        bool DeserializarXML();

        string Propiedad { get; set; }
    }
}
