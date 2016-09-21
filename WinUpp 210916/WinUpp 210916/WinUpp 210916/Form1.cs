using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUpp_210916
{
    public partial class Form1 : Form
    {
        //Starting lists
        System.Collections.ArrayList Category;
        System.Collections.ArrayList Employees;
        System.Collections.ArrayList Customers;
        System.Collections.ArrayList Delivery;



        public Form1()
        {
            InitializeComponent();
            //Seeting starting screen to neutral
            Deliverpnl.Visible = false;
            Customerpnl.Visible = false;
            Employerpnl.Visible = false;


            //Combolist objects
            Category = new System.Collections.ArrayList();


            Categories e = new Categories();
            e.Categorytype = "Employee";
            Category.Add(e);

            Categories c = new Categories();
            c.Categorytype = "Customer";
            Category.Add(c);

            Categories d = new Categories();
            d.Categorytype = "Delivery";
            Category.Add(d);

            //Adding objects to the combolist
            foreach (Categories item in Category)
            {
                Categorycombx.Items.Add(item);
            }
        }



        private void Categorycombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Categorycombx.SelectedIndex)
            {
                case 0:
                    Employerpnl.Visible = true;
                    Deliverpnl.Visible = false;
                    Customerpnl.Visible = false;
                    break;

                case 1:
                    Customerpnl.Visible = true;
                    Deliverpnl.Visible = false;
                    Employerpnl.Visible = false;
                    break;

                case 2:
                    Deliverpnl.Visible = true;
                    Customerpnl.Visible = false;
                    Employerpnl.Visible = false;
                    break;
            }
        }


        private void CustomerSavebtn_Click(object sender, EventArgs e)
        {
            Customers = new System.Collections.ArrayList();
            Customer c = new Customer();
            c.CustomerFirstName = CustomerFNtxtbx.Text;
            c.CustomerLastName = CustomerLNtxtbx.Text;
            c.CustomerTel = CustomerTeltxtbx.Text;
            Customers.Add(c);

            Deliverpnl.Visible = false;
            Customerpnl.Visible = false;
            Employerpnl.Visible = false;

            CustomerFNtxtbx.Text = string.Empty;
            CustomerLNtxtbx.Text = string.Empty;
            CustomerTeltxtbx.Text = string.Empty;

            UpdateHumanoidlist();

        }

        private void EmployeeSavebtn_Click(object sender, EventArgs e)
        {
            Employees = new System.Collections.ArrayList();
            Employee f = new Employee();
            f.EmployeeFirstName = EmployeeFNtxtbx.Text;
            f.EmployeeLastName = EmployeeLNtxtbx.Text;
            f.EmployeeTel = EmployeeTeltxtbx.Text;
            f.EmployeeTitle = EmployeeTitletxtbx.Text;
            f.EmployeeSalary = EmployeeSalarytxtbx.Text;
            Employees.Add(f);

            Deliverpnl.Visible = false;
            Customerpnl.Visible = false;
            Employerpnl.Visible = false;

            EmployeeFNtxtbx.Text = string.Empty;
            EmployeeLNtxtbx.Text = string.Empty;
            EmployeeTeltxtbx.Text = string.Empty;
            EmployeeTitletxtbx.Text = string.Empty;
            EmployeeSalarytxtbx.Text = string.Empty;

             UpdateHumanoidlist();

        }


        private void DeliverySavebtn_Click(object sender, EventArgs e)
        {
            Delivery = new System.Collections.ArrayList();
            Deliver d = new Deliver();
            d.DeliveryContact = DeliveryComtxtbx.Text;
            d.DeliveryCompany = DeliveryComptxtbx.Text;
            d.DeliveryTel = DeliveryTeltxtbx.Text;
            Delivery.Add(d);

            Deliverpnl.Visible = false;
            Customerpnl.Visible = false;
            Employerpnl.Visible = false;

            DeliveryComtxtbx.Text = string.Empty;
            DeliveryComptxtbx.Text = string.Empty;
            DeliveryTeltxtbx.Text = string.Empty;
        
            UpdateHumanoidlist();

        }

            public void UpdateHumanoidlist()
            {
                Personallstbx.Items.Clear();

                        foreach (Customer j in Customers)
                {
                    Personallstbx.Items.Add(j);

                }

                        foreach (Employee t in Employees)
                {
                    Personallstbx.Items.Add(t);

                }

                foreach (Deliver h in Delivery)
                {
                    Personallstbx.Items.Add(h);

                }




            }
            
    }
}
