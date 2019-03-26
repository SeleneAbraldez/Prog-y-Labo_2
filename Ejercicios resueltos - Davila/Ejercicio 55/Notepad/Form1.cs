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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = openFileDialog1.FileName;
                    //Stream stream = openFileDialog1.OpenFile();
                    StreamReader file = new StreamReader(path);
                    richTextBox1.Text = file.ReadToEnd();
                    file.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void guardarCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                StreamWriter file = new StreamWriter(path);
                file.WriteLine(richTextBox1.Text);
                file.Close();
            }
            else
            {
                guardarComoCtrlMayúsSToolStripMenuItem_Click(sender,e);
            }
        }

        private void guardarComoCtrlMayúsSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();

            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = sfDialog.FileName;
                    //Stream stream = openFileDialog1.OpenFile();
                    StreamWriter file = new StreamWriter(path);
                    file.WriteLine(richTextBox1.Text);
                    file.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
