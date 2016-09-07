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

            //Chosing yes or no to continue


                Random draw = new Random();
                int Cards = 104;
                int score = 0;
            //Added drawing restrictions
            while (Cards > 0)
            {
                Console.WriteLine("Would you like a card?(Y/N)");
                string yesorno = Console.ReadLine();
                if (yesorno == "y")
                {

                    int colour = draw.Next(0, 8);
                    int number = draw.Next(0, 13);
                    if (carddeck[colour, number])
                    {
                        switch (colour)
                        //Chosing colour
                        {
                            case 0:
                                Console.WriteLine("You draw {0} of Hearts.", number + 1);
                                break;


                            case 1:
                                Console.WriteLine("You drew {0} of Diamonds.", number + 1);
                                break;

                            case 2:
                                Console.WriteLine("You drew {0} of Spades.", number + 1);
                                break;

                            case 3:
                                Console.WriteLine("You drew {0} of Clovers.", number + 1);
                                break;
                            case 4:
                                Console.WriteLine("You drew {0} of Hearts.", number + 1);
                                break;


                            case 5:
                                Console.WriteLine("You drew {0} of Diamonds.", number + 1);
                                break;

                            case 6:
                                Console.WriteLine("You drew {0} of Spades.", number + 1);
                                break;

                            case 7:
                                Console.WriteLine("You drew {0} of Clovers.", number + 1);
                                break;

                        }
                        switch (number)
                        //Chosing number
                        {
                            case 0:
                                Console.WriteLine();
                                break;

                            case 1:
                                Console.WriteLine();
                                break;

                            case 2:
                                Console.WriteLine();
                                break;

                            case 3:
                                Console.WriteLine();
                                break;

                            case 4:
                                Console.WriteLine();
                                break;

                            case 5:
                                Console.WriteLine();
                                break;

                            case 6:
                                Console.WriteLine();
                                break;
                            case 7:
                                Console.WriteLine();
                                break;

                            case 8:
                                Console.WriteLine();
                                break;

                            case 9:
                                Console.WriteLine();
                                break;

                            case 10:
                                Console.WriteLine();
                                break;
                            case 11:
                                Console.WriteLine();
                                break;

                            case 12:
                                Console.WriteLine();
                                break;

                        }
                        carddeck[colour, number] = false;
                        Cards--;
                        //Added score counter
                        score = (number + 1) + score;

                        Console.WriteLine("Your score is {0} points!", score);
                        if (score > 21)
                        {
                            Console.WriteLine("You are full, better luck next time!");
                            score = 0;

                        }
                        if (score ==21)
                        {
                            Console.WriteLine("You win!");
                            return;
                        }
                    }
                }
                if (yesorno == "n")
                {
                    Console.WriteLine("Score reset.");
                    score = 0;
                }
            }
                Console.WriteLine("No more cards in shoe.");
            Console.ReadLine();

        }
    }
}
