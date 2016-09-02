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
            //Where the names for the program is stated.
            Console.WriteLine("Enter firstname");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lname = Console.ReadLine();
            Console.WriteLine(string.Format("Hello {0} {1}. ", fname, lname));

            string counterorexit = Console.ReadLine();

            //Created loop to avoid program crashing when no/wrong value is written.
            while (true)
            {
                Console.WriteLine("Write Counter or Exit to proceed");
                string s = Console.ReadLine();
                if (s == "Counter")
                {
                    {

                        string f = fname + lname;
                        if (f.Length > -1)
                        {
                            //Stated summary of counting command.
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

                        //Easy-to-see counting for every letter.
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
                        //Added method for reversing letters. See "static string Reverseletters".
                        Console.WriteLine(Reverseletters(lname));
                        Console.WriteLine(Reverseletters(fname));
                        Console.ReadLine();

                        for (int i = 0; i < f.Length; i++)
                        {
                            if (i % 2 == 1)
                            {
                                Console.Write(f[i].ToString().ToLower());
                            }
                            else
                            {
                                Console.Write(f[i].ToString().ToUpper());
                            }
                            Console.WriteLine("");
                        }


                        break;



                    }
                }
                //Exit process.
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
            //Method for reversing letters.
            char[] name = reverseName.ToCharArray();
            Array.Reverse(name);

            return new string(name);


        }
    }
}
