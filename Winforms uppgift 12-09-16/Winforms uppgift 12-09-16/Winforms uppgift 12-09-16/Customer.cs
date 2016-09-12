using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_uppgift_12_09_16
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
