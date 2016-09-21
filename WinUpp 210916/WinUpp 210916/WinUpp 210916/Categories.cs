using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_210916
{
    class Categories
    {
        public string Categorytype { get; set; }

        public string Cat()
        {
            return string.Format("{0}", Categorytype);
        }
        public override string ToString()
        {
            return string.Format("{0}", Categorytype);
        }
    }
}
