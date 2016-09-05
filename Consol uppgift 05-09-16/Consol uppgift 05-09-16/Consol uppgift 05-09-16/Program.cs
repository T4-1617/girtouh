using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_uppgift_05_09_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added bool for card values
            bool[,] card = new bool[3, 12];
            {
                Console.WriteLine("Dra ett kort!");
                Console.ReadLine();
                Random draw = new Random();
                {
                    int colour = draw.Next(0, 3);
                    int number = draw.Next(0, 12);
                    //Tells which colour was drawn
                    switch(colour)
                    {
                        case 0:
                        Console.WriteLine("Du drog ett hjärter!");
                            break;

                        case 1:
                            Console.WriteLine("Du drog ett klöver!");
                            break;

                        case 2:
                            Console.WriteLine("Du drog ett ruter!");
                            break;

                        case 3:
                            Console.WriteLine("Du drog ett spader!");
                            break;
                    }
                    switch(number)
                    {
                        case 0:
                            Console.WriteLine("Du drog ess!");
                            break;

                        case 1:
                            Console.WriteLine("Du drog två!");
                            break;

                        case 2:
                            Console.WriteLine("Du drog tre!");
                            break;

                        case 3:
                            Console.WriteLine("Du drog fyra!");
                            break;

                        case 4:
                            Console.WriteLine("Du drog fem!");
                            break;

                        case 5:
                            Console.WriteLine("Du drog sex!");
                            break;

                        case 6:
                            Console.WriteLine("Du drog sju!");
                            break;
                        case 7:
                            Console.WriteLine("Du drog åtta!");
                            break;

                        case 8:
                            Console.WriteLine("Du drog nio!");
                            break;

                        case 9:
                            Console.WriteLine("Du drog tio!");
                            break;

                        case 10:
                            Console.WriteLine("Du drog knekt!");
                            break;

                        case 11:
                            Console.WriteLine("Du drog dam!");
                            break;

                        case 12:
                            Console.WriteLine("Du drog kung!");
                            break;
                    }

                }

            }
        }
    }
}
