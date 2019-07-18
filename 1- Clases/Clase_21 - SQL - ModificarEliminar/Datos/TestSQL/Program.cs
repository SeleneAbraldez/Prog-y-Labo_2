using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace TestSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region comentadisimo papá
            //AccesoDatos accseDatos = new AccesoDatos();
            //List<Persona> listaPer = new List<Persona>();
            //Persona pers1 = new Persona(10, "Julie", "Mert", 24);
            //DataTable dt = new DataTable();

            //listaPer = accseDatos.TraerTodos();

            //#region listar personas en listaP
            ////foreach (Persona per in listaPer)
            ////{
            ////    Console.WriteLine(per);
            ////}
            ////accseDatos.TablaPersonas();
            //#endregion

            //dt = accseDatos.TraerTablaPersonas();

            //#region listar dataRow
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Console.WriteLine(dr[0].ToString() + " " + dr["nombre"] + " " + dr["apellido"] + " " + dr["edad"]);
            //}
            //#endregion

            //#region serializar data table metodo
            //dt.WriteXmlSchema("Personas_esquemas.xml");
            //dt.WriteXml("Personas_datos.xml");
            //#endregion
            #endregion

            DataTable dt = new DataTable();
            dt.ReadXmlSchema("Personas_esquemas.xml");
            dt.ReadXml("Personas_datos.xml");

            Console.ReadKey();
        }
    }
}
