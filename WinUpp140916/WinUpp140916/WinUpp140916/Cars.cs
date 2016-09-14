using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp140916
{
    class Cars
    {

        public string CarName { get; set; }

        public string CarNumber { get; set; }

        public string CarColour { get; set; }

        public string Bilnamn()
        {

            return string.Format("{0}", CarName);
        }

        public Cars()
        {
            CarName = string.Empty;
            CarNumber = string.Empty;
            CarColour = string.Empty;
        }


    }
}
