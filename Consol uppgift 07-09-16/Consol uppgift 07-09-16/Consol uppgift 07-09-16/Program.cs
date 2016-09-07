using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_uppgift_07_09_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added restriction for card values 
            bool[,] carddeck = new bool[8, 13];

            for (int colour = 0; colour < 8; colour++)
            {
                for (int number = 0; number < 13; number++)
                {
                    carddeck[colour, number] = true;
                }
            }
            Console.WriteLine("Would you like a card?(Y/N)");
            string yesorno = Console.ReadLine();
            if (yesorno == "y")
            {
                Random draw = new Random();
                int Cards = 104;
                int points = 0;
                //Added drawing restrictions
                while (Cards > 0 && points != 21)
                {
                    int colour = draw.Next(0, 8);
                    int number = draw.Next(0, 13);
                    switch (colour)
                        //Chosing colour
                    {
                        case 0:
                            Console.Write("Du drog Hjärter");
                            break;

                        case 1:
                            Console.Write("D");
                            break;

                        case 2:
                            Console.Write("S");
                            break;

                        case 3:
                            Console.Write("C");
                            break;

                        case 4:
                            Console.Write("H");
                            break;

                        case 5:
                            Console.Write("D");
                            break;

                        case 6:
                            Console.Write("S");
                            break;

                        case 7:
                            Console.Write("C");
                            break;

                    }
                    switch (number)
                        //Chosing number
                    {
                        case 0:
                            Console.Write("1");
                            break;

                        case 1:
                            Console.Write("2");
                            break;

                        case 2:
                            Console.Write("3");
                            break;

                        case 3:
                            Console.Write("4");
                            break;

                        case 4:
                            Console.Write("5");
                            break;

                        case 5:
                            Console.Write("6");
                            break;

                        case 6:
                            Console.Write("7");
                            break;
                        case 7:
                            Console.Write("8");
                            break;

                        case 8:
                            Console.Write("9");
                            break;

                        case 9:
                            Console.Write("10");
                            break;

                        case 10:
                            Console.Write("J");
                            break;
                        case 11:
                            Console.Write("D");
                            break;

                        case 12:
                            Console.Write("K");
                            break;

                    }

                    
                }
            }

        }
    }
}
