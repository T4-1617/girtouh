using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = 500; //Frekvens
            int w = 250;
            int z = 350;
            int i = 698;//Hertz
            int q = 830;
            int r = 932;
            int s = 622;
            int t = 1042;


            Console.Beep(i, f);
            Console.Beep(q, f);
            Console.Beep(i, w);
            Console.Beep(i, w);
            Console.Beep(r, z);
            Console.Beep(i, z);
            Console.Beep(s, z);
            Console.Beep(i, f);
            Console.Beep(t, f);
            Console.Beep(i, w);
            Console.Beep(i, w);
            Console.Beep(t, w);
            Console.Beep(r, w);
            Console.Beep(q, w);


        }
    }
}
