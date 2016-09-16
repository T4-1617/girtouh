using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_160916
{
    class Car
    {

        public string CarMaker { get; set; }

        public string CarModel { get; set; }

        public string CarColour { get; set; }

        public string CarNumber { get; set; }

        public string CarNameAndNumber()
        {

            return string.Format("{0} {1}", CarMaker, CarModel);

        }


    }
}
