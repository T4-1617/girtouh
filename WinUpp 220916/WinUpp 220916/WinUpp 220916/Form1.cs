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

            Accountcombx.Visible = false;
            label2.Visible = false;
            AddAccount.Visible = false;
            AddFundsBtn.Visible = false;
            ViewFudnsBtn.Visible = false;
            label7.Visible = false;
            WithdrawFundsBtn.Visible = false;


            UpdatePanels(false, false, false,false);


        }

        private void CustomerOrEmployeecombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CustomerOrEmployeecombx.SelectedIndex)
            {
                case 0:
                    UpdatePanels(true, false, false,false);
                    break;

                case 1:
                    UpdatePanels(false, true, false,false);
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

            UpdatePanels(true, false, false,false);

            ClearBoxes();

        }

        private void Customercombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Accountcombx.Visible = true;
            label2.Visible = true;
            AddAccount.Visible = true;

        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            AddAccountpnl.Visible = true;

        }
        private void AddAccountConfbtn_Click(object sender, EventArgs e)
        {

            
            AccountforCustomer u = new AccountforCustomer(decimal.Parse(InitialDeposittxt.Text));
            u.AccountName = Accountnametxt.Text;
            //u.FundsforAccount(InitialDeposittxt.Text);
            CustomerAccount.Add(u);

            Accountcombx.Items.Add(u);
            UpdatePanels(true, false, false,false);

            ClearBoxes();
        }

        public void UpdatePanels(bool ShowCustomerPanel, bool ShowEmployeePanel, bool ShowAddAccountPanel, bool ShowAddCustomerPanel)
        {
            Customerpnl.Visible = ShowCustomerPanel;
            Employeepnl.Visible = ShowEmployeePanel;
            AddAccountpnl.Visible = ShowAddAccountPanel;
            AddCustomerpnl.Visible = ShowAddCustomerPanel;

        }

        public void ClearBoxes()
        {
            CustomerFirstNametxt.Text = string.Empty;
            CustomerLastNametxt.Text = string.Empty;
            Accountnametxt.Text = string.Empty;
            InitialDeposittxt.Text = string.Empty;
        }

        private void Accountcombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddFundsBtn.Visible = true;
            WithdrawFundsBtn.Visible = true;
            ViewFudnsBtn.Visible = true;

        }

        private void ViewFudnsBtn_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label7.Text = ((AccountforCustomer)CustomerAccount[0]).Balance.ToString();
        }
    }
}
