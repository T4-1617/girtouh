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

                            Console.WriteLine
                                (string.Format
                                ("Firstname and lastname: {0} {1} contains {2} letters, without space.",
                                fname, lname, f.Length));
                            Console.WriteLine
                                (string.Format
                                ("Firstname: {0} contains {1} letters.", fname, fname.Length));
                            Console.WriteLine
                                (string.Format
                                ("Lastname: {0}, contains {1} letters.", lname, lname.Length));
                        }


                        for (int i = 0; i < fname.Length; i++)

                        {
                            Console.WriteLine((i + 1) + "---->" + fname[i]);

                        }
                        for (int i = 0; i < lname.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "------->" + lname[i]);
                        }
                        Console.WriteLine("Press enter to proceed");
                        Console.ReadLine();

                        Console.WriteLine(Reverseletters(lname));
                        Console.WriteLine(Reverseletters(fname));
                        Console.ReadLine();

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
        static string Reverseletters(string reverseName)
        {
            char[] name = reverseName.ToCharArray();
            Array.Reverse(name);

            return new string(name);


        }
    }
}
