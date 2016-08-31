using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniräknare_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett heltal.");
            int heltal0 = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Ange ett till heltal.");
            int heltal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Ange operation.");

            Console.WriteLine("");
            Console.WriteLine("+    -   x   /");
            string operation = Console.ReadLine();
            if (operation == "+")
            {
                Console.WriteLine(heltal0.ToString() + "+" + heltal1.ToString() + "=" + (heltal0 + heltal1).ToString());
                Console.ReadLine();

            }
            else if (operation == "-")
            {
                Console.WriteLine(heltal0.ToString() + "-" + heltal1.ToString() + "=" + (heltal0 - heltal1).ToString());
                Console.ReadLine();

            }
            else if (operation == "x")
            {
                Console.WriteLine(heltal0.ToString() + "x" + heltal1.ToString() + "=" + (heltal0 * heltal1).ToString());
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                Console.WriteLine(heltal0.ToString() + "/" + heltal1.ToString() + "=" + (heltal0 / heltal1).ToString());

            }


        }
    }
}
