using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinÖv150916
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList CustomersAndEmployees;

        public Form1()
        {
            InitializeComponent();
            CustomersAndEmployees = new System.Collections.ArrayList();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //Skapa en kund
            //Spara undan i en lista/datastruktur
            //Visa upp alla kunder i en listbox/gui

            Customer c = new Customer();
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;


            //Alternativ
            CustomersAndEmployees.Add(new Customer() { LastName = txtLastName.Text, FirstName = txtFirstName.Text });

            txtFirstName.Text = string.Empty; //Detta är bra
            txtLastName.Text = ""; //Undvik detta
            txtFirstName.Focus();

            //Visa upp alla kunder i
            //foreach (Customer xxx in CustomersAndEmployees)
            //{
            //    listBox1.Items.Add(xxx);
            //    //listBox1
            //    listBox1.DisplayMember = "FullName"; //Detta MÅSTE vara en PROPERTY
            //}

            DisplayCustomersAndEmployees();

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;

            CustomersAndEmployees.Add(emp);

            /*      foreach(var xxx in Customers)
                  {
                      // listBox1.Items.Add(xxx);
                      listBox1.Items.Add(xxx.GetType().ToString());

                  }
                  */
            DisplayCustomersAndEmployees();
        }

        private void DisplayCustomersAndEmployees()
        {
            listBox1.Items.Clear();
            foreach (var xxx in CustomersAndEmployees)
            {
                // listBox1.Items.Add(xxx.GetType().ToString());
                switch (xxx.GetType().Name)
                {
                    case "Customer":
                        listBox1.Items.Add(xxx);
                        break;
                    case "Employee":
                        listBox1.Items.Add("Employee:" + xxx);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
