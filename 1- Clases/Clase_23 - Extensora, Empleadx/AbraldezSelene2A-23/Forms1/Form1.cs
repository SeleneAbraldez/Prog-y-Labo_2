using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;

namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var items in Enum.GetValues(typeof(TipoManejador)))
            {
                cbManejador.Items.Add(items);
            }
        }

        private static void LimiteSueldoEmpleado(EmpleadoMejorado eM, EmpleadoSueldoArgs eSA)
        {
            MessageBox.Show("! Mayor al limite - A empleadx " + eM.Nombre + " legajo " + eM.Legajo + " se le quiso asignar un sueldo de " + eSA.Sueldo.ToString());
        }

        public static void GuardarLoad(EmpleadoMejorado eM, EmpleadoSueldoArgs eSA)
        {
            StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Archivos.log", true);
            try
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine("Nombre: {0} Legajo: {1} Sueldo: {2}", eM.Nombre, eM.Legajo, eSA.Sueldo);
            }
            catch
            {
                MessageBox.Show("!-Error al guardar.");
            }
            finally
            {
                writer.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoMejorado emp1 = new EmpleadoMejorado();

            if ((TipoManejador)cbManejador.SelectedItem == TipoManejador.LimiteSueldo)
            {
                emp1._delLimiteSueldo = new DelSueldo(LimiteSueldoEmpleado);
            }
            else if ((TipoManejador)cbManejador.SelectedItem == TipoManejador.Load)
            {
                emp1._delLimiteSueldo = new DelSueldo(GuardarLoad);
            }
            else if ((TipoManejador)cbManejador.SelectedItem == TipoManejador.Ambos)
            {
                emp1._delLimiteSueldo = new DelSueldo(LimiteSueldoEmpleado);
                emp1._delLimiteSueldo = new DelSueldo(GuardarLoad);
            }

            emp1.Nombre = this.txtBNombre.Text.ToString();
            emp1.Legajo = int.Parse(this.txtBLegajo.Text);
            emp1.Sueldo = float.Parse(this.txtBSueldo.Text);
        }

        private void cbManejador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
