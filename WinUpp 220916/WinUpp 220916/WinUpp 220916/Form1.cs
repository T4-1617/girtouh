using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUpp_220916
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList Categories;
        System.Collections.ArrayList Customers;
        System.Collections.ArrayList CustomerAccount;
        System.Collections.ArrayList Employees;


        public Form1()
        {
            InitializeComponent();


            CustomerAccount = new System.Collections.ArrayList();

            Categories = new System.Collections.ArrayList();
            Customers = new System.Collections.ArrayList();

            Category f = new Category();
            f.Categorytype = "Customer";
            Categories.Add(f);

            Category d = new Category();
            d.Categorytype = "Employee";
            Categories.Add(d);

            foreach (Category item in Categories)
            {
                CustomerOrEmployeecombx.Items.Add(item);
            }

            AddCustomerpnl.Visible = false;

            UpdatePanels(false, false, false);


        }

        private void CustomerOrEmployeecombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CustomerOrEmployeecombx.SelectedIndex)
            {
                case 0:
                    UpdatePanels(true, false, false);
                    break;

                case 1:
                    UpdatePanels(false, true, false);
                    break;

            }

        }

        private void AddCustomerbtn_Click(object sender, EventArgs e)
        {
            AddCustomerpnl.Visible = true;

        }

        private void AddCustomerConfirmbtn_Click(object sender, EventArgs e)
        {

            Customer g = new Customer();
            g.CustomerFirstName = CustomerFirstNametxt.Text;
            g.CustomerLastName = CustomerLastNametxt.Text;
            Customers.Add(g);

            Customercombx.Items.Add(g);

        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            AddAccountpnl.Visible = true;

        }
        private void AddAccountConfbtn_Click(object sender, EventArgs e)
        {
            CustomerAccounts u = new CustomerAccounts();
            u.AccountName = Accountnametxt.Text;
            CustomerAccount.Add(u);

            Accountcombx.Items.Add(u);
            UpdatePanels(true, false, false);
        }

        public void UpdatePanels(bool ShowCustomerPanel, bool ShowEmployeePanel, bool ShowAddAccountPanel)
        {
            Customerpnl.Visible = ShowCustomerPanel;
            Employeepnl.Visible = ShowEmployeePanel;
            AddAccountpnl.Visible = ShowAddAccountPanel;

        }

        public void ClearBoxes()
        {
            CustomerFirstNametxt.Text = string.Empty;
            CustomerLastNametxt.Text = string.Empty;
            Accountnametxt.Text = string.Empty;
        }

    }
}
