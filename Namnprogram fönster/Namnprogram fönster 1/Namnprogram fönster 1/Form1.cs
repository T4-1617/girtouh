using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Namnprogram_fönster_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Hello " + textBox1.Text +" " +" " + textBox2.Text + ". " + age, "Summering");
        }
        string age = ("");
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            age = "Du är ganska ung.";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            age = "Du är en något äldre ungdom.";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            age = "Du är fortfarande en ungdom.";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            age = "Du börjar bli gammal.";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            age = "Du är snart gammal. *Queue Nästan där*";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            age = "Jahap, det gick ju sisådär. Du är gammal.";
        }
    }
}
