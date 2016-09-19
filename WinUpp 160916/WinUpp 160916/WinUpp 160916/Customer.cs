using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_160916
{
    class Customer
    {

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Firstname,Lastname);
        }
        
        public string FullName()
        {
            return string.Format("{0} {1}", Firstname, Lastname);
        }
    }
}
