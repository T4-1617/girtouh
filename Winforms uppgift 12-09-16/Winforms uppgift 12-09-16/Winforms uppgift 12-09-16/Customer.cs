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

        public string IDNumber { get; set; }

        public string status { get; set; }

        public string FullName()
        {

            return string.Format("{0} {1}, ID Number: {2}. Status: Active", FirstName, LastName, IDNumber);
        }

    }
}
