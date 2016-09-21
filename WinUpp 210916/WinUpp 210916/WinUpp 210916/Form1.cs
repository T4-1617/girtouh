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


        //Combo box function
        private void Categorycombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reveals panel of chosen category
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

        //Customer save button function
        private void CustomerSavebtn_Click(object sender, EventArgs e)
        {
            //Adding to costumer list
            Random i = new Random();
            int IDNumber = i.Next(0, 300);
            Customers = new System.Collections.ArrayList();
            Customer c = new Customer();
            c.CustomerIDNumber = IDNumber.ToString();
            c.CustomerFirstName = CustomerFNtxtbx.Text;
            c.CustomerLastName = CustomerLNtxtbx.Text;
            c.CustomerTel = CustomerTeltxtbx.Text;

            Customers.Add(c);

            //Hiding all panels, setting screen to neutral
            Deliverpnl.Visible = false;
            Customerpnl.Visible = false;
            Employerpnl.Visible = false;

            //Clearing textboxes
            CustomerFNtxtbx.Text = string.Empty;
            CustomerLNtxtbx.Text = string.Empty;
            CustomerTeltxtbx.Text = string.Empty;

            UpdateHumanoidlist();

        }

        //Employee save button function
        private void EmployeeSavebtn_Click(object sender, EventArgs e)
        {

            //Adding to employee list
            Employees = new System.Collections.ArrayList();
            Employee f = new Employee();
            f.EmployeeFirstName = EmployeeFNtxtbx.Text;
            f.EmployeeLastName = EmployeeLNtxtbx.Text;
            f.EmployeeTel = EmployeeTeltxtbx.Text;
            f.EmployeeTitle = EmployeeTitletxtbx.Text;
            f.EmployeeSalary = EmployeeSalarytxtbx.Text;
            Employees.Add(f);

            //Hiding all panels, setting screen to neutral
            Deliverpnl.Visible = false;
            Customerpnl.Visible = false;
            Employerpnl.Visible = false;

            //Clearing textboxes
            EmployeeFNtxtbx.Text = string.Empty;
            EmployeeLNtxtbx.Text = string.Empty;
            EmployeeTeltxtbx.Text = string.Empty;
            EmployeeTitletxtbx.Text = string.Empty;
            EmployeeSalarytxtbx.Text = string.Empty;

            UpdateHumanoidlist();

        }

        //Delivery save button function
        private void DeliverySavebtn_Click(object sender, EventArgs e)
        {

            //Adding to delivery list
            Delivery = new System.Collections.ArrayList();
            Deliver d = new Deliver();
            d.DeliveryContact = DeliveryComtxtbx.Text;
            d.DeliveryCompany = DeliveryComptxtbx.Text;
            d.DeliveryTel = DeliveryTeltxtbx.Text;
            Delivery.Add(d);

            //Hiding all panels, setting screen to neutral
            Deliverpnl.Visible = false;
            Customerpnl.Visible = false;
            Employerpnl.Visible = false;

            //Clearing textboxes
            DeliveryComtxtbx.Text = string.Empty;
            DeliveryComptxtbx.Text = string.Empty;
            DeliveryTeltxtbx.Text = string.Empty;

            UpdateHumanoidlist();

        }

        public void UpdateHumanoidlist()
        {
            Personallstbx.Items.Clear();

            if (Customers.Count == 0)
            {
                Personallstbx.Items.Add("No customers");
            }

            if (Employees.Count == 0)
            {
                Personallstbx.Items.Add("No employees");
            }

            if (Delivery.Count == 0)
            {
                Personallstbx.Items.Add("No deliveries");
            }


            if (Customers.Count > 0)
            {
            
                foreach (Customer j in Customers)
                {
                    Personallstbx.Items.Add(j);

                }
            }

            if (Employees.Count > 0)
            {
                foreach (Employee t in Employees)
                {
                    Personallstbx.Items.Add(t);

                }
            }

            if (Delivery.Count > 0)
            {
                foreach (Deliver h in Delivery)
                {
                    Personallstbx.Items.Add(h);

                }

            }

        }

    }
}
