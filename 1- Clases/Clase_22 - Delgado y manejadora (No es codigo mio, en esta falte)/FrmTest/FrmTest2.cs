using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest
{
    public partial class FrmTest2 : Form
    {
        public FrmTest2()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.Inicializar);
        }

        private void FrmTest2_Load(object sender, EventArgs e)
        {

            //Manejador a btnBoton1(MiManejador)
        }

        public void Inicializar(object ev, EventArgs e)
        {

            this.btnBoton1.Click += new EventHandler(this.MiManejador);
        }

        public void MiManejador(object ev, EventArgs e)
        {
            string aux = ((Control)ev).Name;//Name te dice el nombre del boton que pulsas
            MessageBox.Show(aux);

            if(aux == "btnBoton1")
            {
                this.btnBoton2.Click += new EventHandler(this.MiManejador);
                this.btnBoton1.Click -= new EventHandler(this.MiManejador);
            }
            else if(aux == "btnBoton2")
            {
                this.btnBoton3.Click += new EventHandler(this.MiManejador);
                this.btnBoton2.Click -= new EventHandler(this.MiManejador);
            }

            else if(aux == "btnBoton3")
            {
                this.btnBoton1.Click += new EventHandler(this.MiManejador);
                this.btnBoton3.Click -= new EventHandler(this.MiManejador);
            }
          
        }

        private void btnBoton4_Click(object sender, EventArgs e)
        {
            Manejadora auxM = new Manejadora();
            
            MiDelegado del1 = new MiDelegado(Manejadora.Sumar);

            MiDelegado del2 = new MiDelegado(auxM.Restar);

            MiDelegado del3 = (MiDelegado)(MiDelegado.Combine(del1, del2));//Combina a los dos delegados 

            del1.Invoke(3, 2); //de manera explicita
           del2(3, 2);//de manera implicita

            del3.Invoke(5, 3);

            //MessageBox.Show(del3.Method.ToString());
            //MessageBox.Show(del3.Target.ToString()); //Me devuelve la instancia que contiene el metodo de la lista de invocacion

            //del3.GetInvocationList();//Me devuelve cada uno de los metodos asociados
            //foreach(MiDelegado aux in del3.GetInvocationList())
            //{
            //    MessageBox.Show(aux.Method.ToString());
            //}

            MiDelegado del4 = (MiDelegado)MiDelegado.Combine(del3, new MiDelegado(auxM.Multiplicar));

            del4.Invoke(1, 1);

            MiDelegadodOS otroDelegado = new MiDelegadodOS(auxM.OtraSuma);
            otroDelegado.Invoke(del1, 2, 3);

        }

        private void BtnBoton1_Click(object sender, EventArgs e)
        {

        }

        //public delegate void Delegado(object)//La forma que va a tener un delegado,
    }
}
