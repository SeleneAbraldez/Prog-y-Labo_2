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
using IO;
using System.Text.RegularExpressions;

namespace Notepad
{
    public partial class Form1 : Form
    {
        string path = null;

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "0 caracteres";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Format("{0} caracteres", richTextBox1.Text.Length);
        }

        private void abrirCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "Archivos de Texto (.txt)|*.txt|Archivos de Datos (.dat)|*.dat";
            if (fl.ShowDialog() == DialogResult.OK)
            {
                switch (fl.FilterIndex)
                { 
                    case 1:
                        try
                        {
                            path = fl.FileName;
                            PuntoTxt txt = new PuntoTxt();
                            richTextBox1.Text = txt.Leer(path);
                        }
                        catch (Exception)
                        {
                            richTextBox1.Text = "No se pudo leer el archivo!!";
                        }
                        break;

                    case 2:
                        try
                        {
                            PuntoDat dat = new PuntoDat();
                            path = fl.FileName;
                            richTextBox1.Text = dat.Leer(path).Contenido;
                        }
                        catch (Exception)
                        {
                            richTextBox1.Text = "No se pudo leer el archivo!!";
                        }
                        break;                
                }
            }
        }

        private void guardarCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                if(Regex.IsMatch(path,@".+\.dat$"))
                {
                    try
                    {
                        PuntoDat dat = new PuntoDat();
                        dat.Contenido = richTextBox1.Text;
                        dat.Guardar(path);
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.Text = ex.Message;
                    }
                }
                else
                {
                    try
                    {
                        PuntoTxt txt = new PuntoTxt();
                        txt.Contenido = richTextBox1.Text;
                        txt.Guardar(path);
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.Text = ex.Message;
                    }                
                }
            }
            else
            {
                guardarComoCtrlMayúsSToolStripMenuItem_Click(sender,e);
            }
        }

        private void guardarComoCtrlMayúsSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "Archivos de Texto (.txt)|*.txt|Archivos de Datos (.dat)|*.dat";

            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                switch(sfDialog.FilterIndex)
                {
                    case 1:
                        try
                        {
                            PuntoTxt txt = new PuntoTxt();
                            path = sfDialog.FileName;
                            txt.Contenido = richTextBox1.Text;
                            txt.Guardar(path);
                        }
                        catch (Exception ex)
                        {
                            richTextBox1.Text = ex.Message;
                        }
                        break;
                    case 2:
                        try
                        {
                            PuntoDat dat = new PuntoDat();
                            dat.Contenido = richTextBox1.Text;
                            path = sfDialog.FileName;
                            dat.Guardar(path);
                        }
                        catch (Exception ex)
                        {
                            richTextBox1.Text = ex.Message;
                        }
                        break;                
                }
            }
        }
    }
}
