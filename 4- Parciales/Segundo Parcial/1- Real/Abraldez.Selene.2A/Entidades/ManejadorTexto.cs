using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    public class ManejadorTexto
    {
        public void manejadorTexto(double precio)
        {
            using (StreamWriter writer = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "manejadorTexto.txt"), false))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}", DateTime.Now);
                sb.AppendLine();
                sb.AppendFormat("Precio del cajon: {0}", precio);
                writer.Write(sb.ToString());
                writer.Close();
            }
        }
    }
}
