using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_210916
{
    class Deliver
    {
        public string DeliveryContact { get; set; }

        public string DeliveryCompany { get; set; }

        public string DeliveryTel { get; set; }

        public override string ToString()

        {
            return string.Format("Contact: {0}. Company: {1}. Tel.Number: {2}", DeliveryContact, DeliveryCompany, DeliveryTel);
        }
    }
}
