using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_uppgift_12_09_16
{

    public partial class Form1 : Form
    {



        //Adding ID number bool

        //Saving added customers
        List<Customer> CustomerS = new List<Customer>();
        int amount;

        public static int Randomize()
        {
            //Randomizes an ID number
            Random search = new Random();
            int number = search.Next(100, 200);
            return number;
         
        }




        public Form1()
        {
            InitializeComponent();
        }

        //Button adds customers to list box
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            //Uses the generated ID number
            int number = Randomize();
            string Identification;

            

            Identification = number.ToString();

            //Adding customer information

            Customer customs = new Customer();

            customs.FirstName = txtFirstName.Text;
            customs.LastName = txtLastName.Text;
            customs.IDNumber = Identification;
            CustomerS.Add(customs);

            //Rebuilding listbox for each new customer
            listBox1.Items.Clear();



            foreach (Customer item in CustomerS)
                listBox1.Items.Add(item.FullName());
            amount = listBox1.Items.Count;


            //Clearing textboxes
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            //Amount of customers
            label4.Text = string.Format("Du har {0} kunder.", amount);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0}, {1}", CustomerS[listBox1.SelectedIndex].FullName(), CustomerS[listBox1.SelectedIndex].IdentNumber()));
        }
    }
}
