using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_210916
{
    class Supply
    {
        public string SupplierContact { get; set; }

        public string SupplierCompany { get; set; }

        public string SupplierTel { get; set; }

        public override string ToString()

        {
            return string.Format("Contact: {0} - Company: {1}. Tel.Number: {2}", SupplierContact, SupplierCompany, SupplierTel);
        }

        public Supply()
        {
            SupplierContact = string.Empty;

            SupplierCompany = string.Empty;

            SupplierTel = string.Empty;

        }

    }
}
