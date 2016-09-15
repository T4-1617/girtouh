using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinÖv150916
{
    class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        /*
         Detta funkar inte med DisplayMember eftersom det är en METOD
         DisplarMember KRÄVER en PROPERTY

        public string FullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);

        }
        */

        public string FullName
        {

            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }


        }

    }
}
