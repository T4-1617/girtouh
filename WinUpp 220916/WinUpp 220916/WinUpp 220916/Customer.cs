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



        public override string ToString()
        {
            return string.Format("{0} {1}", CustomerFirstName, CustomerLastName);
        }

    }

    public class AccountforCustomer
    {
        private decimal balance;



    }
}
