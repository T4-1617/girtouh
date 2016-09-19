using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_160916
{
    class Car
    {

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string CarMaker { get; set; }

        public string CarModel { get; set; }

        public string CarColour { get; set; }

        public string CarNumber { get; set; }

        public Customer hiredBy { get; set; }

        public bool booked { get; set; }

        public string FullName()
        {
            return string.Format("{0} {1}.", Firstname,Lastname);
        }


        public override string ToString()
        {

            return string.Format("Car: {1} {2}|  Colour: {0} |  Reg. Number: {3}", CarColour, CarMaker, CarModel, CarNumber );

        }



    }

}
