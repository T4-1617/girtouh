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
        System.Collections.ArrayList Supplier;
        int Customercounter = 0;
        int Employeecounter = 0;
        int Suppliercounter = 0;


        public Form1()
        {
            InitializeComponent();

            //Setting up ArrayLists for backing store
            Customers = new System.Collections.ArrayList();
            Employees = new System.Collections.ArrayList();
            Supplier = new System.Collections.ArrayList();


            //Seeting starting screen to neutral
            ClearScreen();


            //Combolist objects
            Category = new System.Collections.ArrayList();


            Categories e = new Categories();
            e.Categorytype = "Employee";
            Category.Add(e);

            Categories c = new Categories();
            c.Categorytype = "Customer";
            Category.Add(c);

            Categories d = new Categories();
            d.Categorytype = "Supplier";
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
                    ShowPanels(false, true, false);
                    break;

                case 1:
                    ShowPanels(true, false, false);
                    break;

                case 2:
                    ShowPanels(false, false, true);
                    break;
            }
        }

        //Customer save button function
        private void CustomerSavebtn_Click(object sender, EventArgs e)
        {
            //Adding to costumer list
            Random i = new Random();
            int IDNumber = i.Next(0, 300);
            Customer c = new Customer();
            c.CustomerIDNumber = IDNumber.ToString();
            c.CustomerFirstName = CustomerFNtxtbx.Text;
            c.CustomerLastName = CustomerLNtxtbx.Text;
            c.CustomerTel = CustomerTeltxtbx.Text;
            Customers.Add(c);

            //Hiding all panels, setting screen to neutral
            ClearScreen();

            //Clearing textboxes
            CustomerFNtxtbx.Text = string.Empty;
            CustomerLNtxtbx.Text = string.Empty;
            CustomerTeltxtbx.Text = string.Empty;

            //Counting customer items
            Customercounter++;

            //Updating listbox
            UpdateHumanoidlist();

        }

        //Employee save button function
        private void EmployeeSavebtn_Click(object sender, EventArgs e)
        {

            //Adding to employee list
            Employee f = new Employee();
            f.EmployeeFirstName = EmployeeFNtxtbx.Text;
            f.EmployeeLastName = EmployeeLNtxtbx.Text;
            f.EmployeeTel = EmployeeTeltxtbx.Text;
            f.EmployeeTitle = EmployeeTitletxtbx.Text;
            f.EmployeeSalary = EmployeeSalarytxtbx.Text;
            Employees.Add(f);


            //Hiding all panels, setting screen to neutral
            ClearScreen();

            //Clearing textboxes
            EmployeeFNtxtbx.Text = string.Empty;
            EmployeeLNtxtbx.Text = string.Empty;
            EmployeeTeltxtbx.Text = string.Empty;
            EmployeeTitletxtbx.Text = string.Empty;
            EmployeeSalarytxtbx.Text = string.Empty;

            //Counting employee items
            Employeecounter++;

            //Updating listbox
            UpdateHumanoidlist();

        }

        //Supplier save button function
        private void SupplierSavebtn_Click(object sender, EventArgs e)
        {

            //Adding to Supplier list
            Supply d = new Supply();
            d.SupplierContact = SupplierComtxtbx.Text;
            d.SupplierCompany = SupplierComptxtbx.Text;
            d.SupplierTel = SupplierTeltxtbx.Text;
            Supplier.Add(d);

            //Hiding all panels, setting screen to neutral
            ClearScreen();

            //Clearing textboxes
            SupplierComtxtbx.Text = string.Empty;
            SupplierComptxtbx.Text = string.Empty;
            SupplierTeltxtbx.Text = string.Empty;

            //Counting supply items
            Suppliercounter++;

            //Updating listbox
            UpdateHumanoidlist();

        }

        //Chosing an object in Personallistbox
        private void Personallstbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Safety if nothing is selected
            if (Personallstbx.SelectedItem == null)
            {

            }

            //Shows clear information of currently selected item in list
            else
            {
                MessageBox.Show(string.Format("{0}", Personallstbx.SelectedItem));

                Personallstbx.SelectedItem = null;
            }

        }

        //Update Listbox
        public void UpdateHumanoidlist()
        {

            //Clears the listbox from everything
            if (Personallstbx != null)
            {
                Personallstbx.Items.Clear();
            }


            //Adding customer objects to list
            Personallstbx.Items.Add("Customers:");

            foreach (Customer j in Customers)
            {
                Personallstbx.Items.Add(j);

            }


            //Adding employee objects to list
            Personallstbx.Items.Add("Employees:");

            foreach (Employee t in Employees)
            {
                Personallstbx.Items.Add(t);

            }


            //Adding supply objects to list
            Personallstbx.Items.Add("Suppliers:");

            foreach (Supply h in Supplier)
            {
                Personallstbx.Items.Add(h);

            }
            //Writing out amount of people in list
            Countinglbl.Text=string.Format("There are {0} Customers, {1} Employees, and {2} Suppliers registered.", Customercounter, Employeecounter,Suppliercounter);

        }

        //Showing panels
        public void ShowPanels(bool ShowCustomerPanel, bool ShowEmployeePanel, bool ShowSupplierPanel)
        {
            Employerpnl.Visible = ShowEmployeePanel;
            Supplierpnl.Visible = ShowSupplierPanel;
            Customerpnl.Visible = ShowCustomerPanel;
        }

        //Setting screen to neutral
        public void ClearScreen()
        {
            Supplierpnl.Visible = false;
            Customerpnl.Visible = false;
            Employerpnl.Visible = false;
        }


    }
}
