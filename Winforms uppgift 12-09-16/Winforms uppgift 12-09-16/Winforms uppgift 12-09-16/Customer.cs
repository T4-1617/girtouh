using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_uppgift_12_09_16
{
    public class Customer
    {
        public static int Randomize()
        {
            bool[,] g = new bool[100, 200];

            //Randomizes an ID number
            Random ID = new Random();
            int l = ID.Next(0, 0);
            int number = ID.Next(100, 200);
            while (g[number, l] == false)
            {
                number = ID.Next(100, 200);
            }

            if (g[number, l] == true)
            {


            }
            g[number, l] = false;

            return number;

        }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IDNumber { get; set; }

        public string status { get; set; }

        public string FullName()
        {
            string ID;
            int number = Randomize();
            ID = number.ToString();

            return string.Format("{0} {1}, ID Number: {2}. Status: Active", FirstName, LastName, ID);
        }

    }
}
