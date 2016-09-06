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
            bool[,] carddeck = new bool[4, 13];

            // Set all cards in deck
            for (int colour = 0; colour < 4; colour++)
            {
                for (int number = 0; number < 13; number++)
                {
                    carddeck[colour, number] = true;
                }
            }


            //The drawing itself, and the maximum amount of cards
            Console.WriteLine("Tryck ENTER för ett kort.");
            Console.ReadLine();
            Random draw = new Random();
            int Card = 52;

            while (Card > 0)
            {
                string p = "Du har {0} kort kvar!";

                int colour = draw.Next(0, 4);
                int number = draw.Next(0, 13);

                if (carddeck[colour, number] == true)
                {
                    //Tells which colour was drawn
                    switch (colour)
                    {
                        case 0:
                            Console.Write("Du drog hjärter", number + p);
                            break;

                        case 1:
                            Console.Write("Du drog klöver", number + p);
                            break;

                        case 2:
                            Console.Write("Du drog ruter", number + p);
                            break;

                        case 3:
                            Console.Write("Du drog spader", number + p);
                            break;
                    }
                    //Tells which number was drawn

                    switch (number)
                    {
                        case 0:
                            Console.WriteLine(" ess.");
                            Console.ReadLine();
                            break;

                        case 1:
                            Console.WriteLine(" två.");
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine(" tre.");
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine(" fyra.");
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine(" fem.");
                            Console.ReadLine();
                            break;

                        case 5:
                            Console.WriteLine(" sex.");
                            Console.ReadLine();
                            break;

                        case 6:
                            Console.WriteLine(" sju.");
                            Console.ReadLine();
                            break;

                        case 7:
                            Console.WriteLine(" åtta.");
                            Console.ReadLine();
                            break;

                        case 8:
                            Console.WriteLine(" nio.");
                            Console.ReadLine();
                            break;

                        case 9:
                            Console.WriteLine(" tio.");
                            Console.ReadLine();
                            break;

                        case 10:
                            Console.WriteLine(" knekt.");
                            Console.ReadLine();
                            break;

                        case 11:
                            Console.WriteLine(" dam.");
                            Console.ReadLine();
                            break;

                        case 12:
                            Console.WriteLine(" kung.");
                            Console.ReadLine();
                            break;
                    }

                    carddeck[colour, number] = false;
                    Card--;
                }

            }


        }
    }
}
