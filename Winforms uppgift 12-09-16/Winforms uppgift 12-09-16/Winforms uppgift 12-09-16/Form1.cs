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
        bool[,] IDnumber = new bool[0, 100];

        //Saving added customers
        System.Collections.ArrayList CustomerS = new System.Collections.ArrayList();
        int amount;
        
        public Form1()
        {
            InitializeComponent();
        }

        //Button adds customers to list box
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            Customer customs = new Customer();

            customs.FirstName = txtFirstName.Text;
            customs.LastName = txtLastName.Text;
            CustomerS.Add(customs);

            //Rebuilding listbox for each new customer
            listBox1.Items.Clear();

            foreach (Customer item in CustomerS)
                listBox1.Items.Add(item.FullName());
            amount = listBox1.Items.Count;

            //Amount of customers
            label4.Text = string.Format("Du har {0} kunder.", amount);
        }
    }
}
