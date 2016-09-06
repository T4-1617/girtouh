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
            int points = 0;

            while (Card > 0)
            {


                int colour = draw.Next(0, 4);
                int number = draw.Next(0, 13);

                if (carddeck[colour, number] == true)
                {
                    //Tells which colour was drawn
                    switch (colour)
                    {
                        case 0:
                            Console.Write("Du drog hjärter");
                            break;

                        case 1:
                            Console.Write("Du drog klöver");
                            break;

                        case 2:
                            Console.Write("Du drog ruter");
                            break;

                        case 3:
                            Console.Write("Du drog spader");
                            break;
                    }
                    //Tells which number was drawn

                    switch (number)
                    {
                        case 0:
                            Console.Write(" ess.");
                            break;

                        case 1:
                            Console.Write(" två.");
                            break;

                        case 2:
                            Console.Write(" tre.");
                            break;

                        case 3:
                            Console.Write(" fyra.");
                            break;

                        case 4:
                            Console.Write(" fem.");
                            break;

                        case 5:
                            Console.Write(" sex.");
                            break;

                        case 6:
                            Console.Write(" sju.");
                            break;

                        case 7:
                            Console.Write(" åtta.");
                            break;

                        case 8:
                            Console.Write(" nio.");
                            break;

                        case 9:
                            Console.Write(" tio.");
                            break;

                        case 10:
                            Console.Write(" knekt.");
                            break;

                        case 11:
                            Console.Write(" dam.");
                            break;

                        case 12:
                            Console.Write(" kung.");
                            break;
                    }

                    carddeck[colour, number] = false;
                    Card--;
                    //Added card counter
                    Console.Write(String.Format(" Du har {0} kort kvar. Det här är kort nummer {1}.", Card, (52 - Card)));
                    points = (number + 1) + points;
                    Console.WriteLine(" Du har {0} poäng!", points);
                    Console.ReadLine();

                }

            }


        }
    }
}
