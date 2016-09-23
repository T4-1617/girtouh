using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_220916
{
    class Customer
    {
        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public CustomerAccounts User;

        public override string ToString()
        {
            return string.Format("{0} {1}", CustomerFirstName, CustomerLastName);
        }

    }
}
