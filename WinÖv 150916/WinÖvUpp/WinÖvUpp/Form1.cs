using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinÖvUpp
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList CustomersAndEmployees;

        public Form1()
        {
            InitializeComponent();
            CustomersAndEmployees = new System.Collections.ArrayList();
            FirstNametxt.Focus();

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (Employeeradbtn.Checked==true)
            {
                Employee emp = new Employee();
                emp.FirstName = FirstNametxt.Text;
                emp.LastName = LastNametxt.Text;
            }

            if (Customerradbtn.Checked==true)
            {
                Customer cus = new Customer();
                cus.FirstName = FirstNametxt.Text;
                cus.LastName = LastNametxt.Text;
            }
            else
            {
                MessageBox.Show("Please check customer or employee");
            }

        }
        private void ShowCustomersAndEmployees()
        {
            if (Employeeradbtn.Checked==true)
            {
                EmployeelistBox.Items.Clear();
                foreach (Employee item in CustomersAndEmployees)
                {

                }
            }
            CustomerlistBox.Items.Clear();
        }


    }
}
