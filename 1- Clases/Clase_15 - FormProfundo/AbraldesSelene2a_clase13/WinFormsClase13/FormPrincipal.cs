using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsClase13
{
    public partial class FormPrincipal : Form
    {
        string path = "";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.openFileDialog.Title = "Selecciona un archivo para guardar";
            //this.openFileDialog.Multiselect = true;
            this.openFileDialog.FileName = "miArchivo";
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.AddExtension = true;
            this.openFileDialog.Filter = "Archivos *.txt|*.TXT";
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (path != "")
                {
                    StreamWriter escritura = new StreamWriter(path, true);
                    string valor = this.txtValor.Text;
                    escritura.WriteLine("{0}", valor);
                    escritura.Close();
                    this.txtValor.Text = "";
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado una ruta valida. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                StreamReader lectura = new StreamReader(path, true);
                this.lstVisor.Items.Clear();
                while (!lectura.EndOfStream)
                {
                    this.lstVisor.Items.Add(lectura.ReadLine());
                }
                lectura.Close();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una ruta valida. ");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = this.openFileDialog.FileName;
                MessageBox.Show(this.openFileDialog.FileName);
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

//arroba al princpio del string path no necesita doble barra
//path- donde se guarda // append-si esta en true agrega, en false reescribe y pisa
///excp: puede suceder que no tenga permiso para el path, que este no exista, que la longingitud supere 200, etc
////escritura.Write(""); y escritura.WriteLine("");
//escritura.Close(); //importarte cerrarlo para no pisar

//path = AppDomain.CurrentDomain.BaseDirectory + @"\miArchivo.txt";
//path = @"C:\Users\alumno\Desktop\miArchivo.txt";
//path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\miArchivo.txt";