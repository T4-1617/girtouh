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
                {
                    {

                        


                        //Arbete
                        string f = fname + lname;


                        if (f.Length > -1)
                        {
                            Console.WriteLine("Firsname and lastname: " + fname + " " + lname + ", contains "+f.Length+" letters, without space.");
                            Console.WriteLine("Firstname: " + fname+", contains " + fname.Length + " letters.");
                            Console.WriteLine("Lastname: " + lname + ", contains " + lname.Length + " letters.");
                        }


                       for (int i = 0; i < f.Length; i++)

                        {
                            Console.WriteLine((i+1)+"---->" + f[i]);



                        }





                        break;
                        //Arbete

                    }
                }


                if (s == "Exit")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Bye!");
                    break;
                }

            }


        }
    }
}
