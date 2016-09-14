using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinÖv
{
    public partial class Form1 : Form
    {
        //Detta är en CONSTRUCTOR och körs alltid automatiskt direkt vid New
        //Använd ALLTID en constructor
        //En constructor har samma namn som klassen och ingen retur typ inte ens void

        System.Collections.ArrayList MyCustomers;
        

        public Form1()
        {

            InitializeComponent();
            MyCustomers = new System.Collections.ArrayList();
            panel1.Visible = false;


            Customer c = new Customer() { Name = "Fillimon Putt", Secret= "1234" };

            listBox1.Items.Add(c);
            listBox1.DisplayMember = "Name"; //OBS: Tar endast (1) PropertyName från Customer

            //Eftersom listboxen inte vet vad den ska visa från Customer
            //så anropar den .ToString()
            //AOOA objekt kan svara på To.String()
            //men för oss blir det då default namespace.klassnamn
            //inte kul...

            //Hmm, någon borde ha tänkt på detta innan...
            //JA. ToString är en metod som kan anpassas, dvs. overridable
            //Kolla customer-Klassen...bb

            //ALT
            //listBox1.Items.Add(c.FirstName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Jag vill skriva ut .Secret
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            MessageBox.Show(listBox1.SelectedItem.GetType().ToString());

            Customer c = (Customer)listBox1.SelectedItem;
            // MessageBox.Show(c.Secret);

            //Alt med panel

            panel1.Visible = true;
            label1.Text = string.Format("The secret is {0}", c.Secret);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
