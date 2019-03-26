using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char delimitador = ' ';
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string[] palabras = richTextBox1.Text.Split(delimitador);
            
            foreach(string palabra in palabras){
                if (diccionario.ContainsKey(palabra))
                {
                    diccionario[palabra] = diccionario[palabra] + 1;
                }
                else 
                {
                    diccionario.Add(palabra, 1);                
                }
            }

            int maximo = 0;
            bool flag = false;
            foreach(int valor in diccionario.Values){                               
                if(flag == false){
                    maximo = valor;
                    flag = true;
                }
                else if(valor > maximo)
                {
                    maximo = valor;
                }           
            }
            string mensaje = "";
            foreach (KeyValuePair<string,int> item in diccionario.OrderByDescending(keyValuePair => keyValuePair.Value).Take(3))
            {
                mensaje = mensaje + item.Key + " = " + item.Value + "\n";
            }

            MessageBox.Show(mensaje);
                
            
        }

            
        
    }
}
