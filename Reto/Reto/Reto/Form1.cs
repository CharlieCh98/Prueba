using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto
{
    public partial class Form1 : Form
    {
        Thread thread;
        delegate void dlgt(int value);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(producirDonaChocolate));
            thread.Start();

            thread = new Thread(new ThreadStart(producirDonaVainilla));
            thread.Start();

            thread = new Thread(new ThreadStart(producirDonaCanela));
            thread.Start();
        }

        //Metodos
        public void producirDonaChocolate()
        {
            for(int i = 0; i <101; i++)
            {
                dlgt d1 = new dlgt(contadorDonaChocolate);
                Invoke(d1, new object[] { i });
                Thread.Sleep(5000);
            }
        }
        public void producirDonaVainilla()
        {
            for (int i = 0; i < 101; i++)
            {
                dlgt d2 = new dlgt(contadorDonaVainilla);
                Invoke(d2, new object[] { i });
                Thread.Sleep(3000);
            }
        }
        public void producirDonaCanela()
        {
            for (int i = 0; i < 101; i++)
            {
                dlgt d3 = new dlgt(contadorDonaCanela);
                Invoke(d3, new object[] { i });
                Thread.Sleep(10000);
            }
        }

        public void contadorDonaChocolate(int value)
        {
            labelChocolate.Text = value.ToString();
        }
        public void contadorDonaVainilla(int value)
        {
            labelVainilla.Text = value.ToString();
        }
        public void contadorDonaCanela(int value)
        {
            labelCanela.Text = value.ToString();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 101; i++)
                {
                    dlgt d1 = new dlgt(contadorDonaChocolate);
                    Invoke(d1, new object[] { i });
                    Thread.Sleep(5000);
                }

                for (int i = 0; i < 101; i++)
                {
                    dlgt d2 = new dlgt(contadorDonaVainilla);
                    Invoke(d2, new object[] { i });
                    Thread.Sleep(3000);
                }
          
                for (int i = 0; i < 101; i++)
                {
                    dlgt d3 = new dlgt(contadorDonaCanela);
                    Invoke(d3, new object[] { i });
                    Thread.Sleep(10000);
                }
            }
            catch (ThreadAbortException)
            {

                Thread.ResetAbort();
            }
            
        }
    }
}
