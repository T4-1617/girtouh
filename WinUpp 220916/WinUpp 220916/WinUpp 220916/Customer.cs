using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_220916
{
    class Customer
    {
        private System.Collections.ArrayList CustomerAccounts;

        public Customer()
        {
            CustomerAccounts = new System.Collections.ArrayList();
        }


        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public void FundsforAccount(decimal InitialDeposit)
        {
            if (InitialDeposit >=1000)
            {
                AccountforCustomer a = new AccountforCustomer(InitialDeposit);

                //a.Deposit(InitialDeposit);
                CustomerAccounts.Add(a);
            }

        }

        public override string ToString()
        {
            return string.Format("{0} {1}", CustomerFirstName, CustomerLastName);
        }

    }

    public class AccountforCustomer
    {
        private decimal balance;

        public string AccountName { get; set; }

        public AccountforCustomer(decimal starting_fund)
        {
            balance = starting_fund;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Withdraw (decimal changedamount)
        {
            balance = balance - changedamount;
        }

        public void Deposit(decimal changedamount)
        {
            balance = balance + changedamount;

        }   


    }
}
