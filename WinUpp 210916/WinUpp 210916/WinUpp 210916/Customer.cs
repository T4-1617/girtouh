using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_210916
{
    class Customer
    {
        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string CustomerFullName()
        {
            return string.Format("{0} {1}", CustomerFirstName, CustomerLastName);
        }

        public string CustomerIDNumber { get; set; }

        public string CustomerTel { get; set; }

        public override string ToString()

        {
            return string.Format("{0} {1} - Tel.Number: {2}. CustomerNumber: {3}", CustomerFirstName, CustomerLastName, CustomerTel, CustomerIDNumber);
        }

        public Customer()
        {
            CustomerFirstName = string.Empty;
            CustomerLastName = string.Empty;
            CustomerTel = string.Empty;
            CustomerIDNumber = string.Empty;

        }
    }
}
