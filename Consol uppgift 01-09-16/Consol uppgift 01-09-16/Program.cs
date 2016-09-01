using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_uppgift_01_09_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter firstname");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lname = Console.ReadLine();
            Console.WriteLine("Hello " + fname + " " + lname + ".");

            string counterorexit = Console.ReadLine();


            while (true)
            {
                Console.WriteLine("Write Counter or Exit to proceed");
                string s = Console.ReadLine();
                if (s == "Counter")
                

                    //Arbete
                    if (fname.Length != 0)
                    {
                        Console.WriteLine(fname);
                    }

                    string numbers = fname + lname;
                    foreach (char item in numbers)
                    {
                        Console.WriteLine(item + " <-----This is a letter");
                        Console.WriteLine(item);






                        break;
                    //Arbete
                }



                if (s == "Exit")
                {
                    Console.WriteLine("Bye!");
                    break;
                }

            }
            
            
        }
    }
}
