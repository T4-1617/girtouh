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

                    switch(colour)
                    {
                        case 1:
                        Console.WriteLine("Du drog ett hjärter!");
                            break;

                        case 2:
                            Console.WriteLine("Du drog ett klöver!");
                            break;

                        case 3:
                            Console.WriteLine("Du drog ett ruter!");
                            break;

                        case 4:
                            Console.WriteLine("Du drog ett spader!");
                            break;
                    }
                }

            }
        }
    }
}
