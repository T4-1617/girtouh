using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_220916
{
    class CustomerAccounts
    {
        public string AccountName { get; set; }

        public override string ToString()
        {
            return string.Format("{0}",AccountName);
        }
    }
}
