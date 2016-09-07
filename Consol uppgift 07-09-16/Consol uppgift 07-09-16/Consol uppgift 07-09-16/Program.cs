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
                //Card counter
                Console.WriteLine(Cards);
                if (yesorno == "y")
                {

                    string num;
                    int colour = draw.Next(0, 8);
                    int number = draw.Next(0, 13);
                    //Searches for undrawn cards
                    while(carddeck[colour, number] ==false)
                    {
                       colour = draw.Next(0,8);
                        number = draw.Next(0, 13);
                    }
                    if (carddeck[colour, number]==true)
                    {



                        switch (number)
                        //Chosing number
                        {
                            case 0:
                                num = "ace";
                                break;

                               case 1:
                                   num = "2";
                                   break;

                               case 2:
                                   num = "3";
                                   break;

                               case 3:
                                   num = "4";
                                   break;

                               case 4:
                                   num = "5";
                                   break;

                               case 5:
                                   num = "6"; ;
                                   break;

                               case 6:
                                   num = "7";
                                   break;

                               case 7:
                                   num = "8";
                                   break;

                               case 8:
                                   num = "9";
                                   break;

                               case 9:
                                   num = "10";
                                   break;

                               case 10:
                                   num = "Jack";
                                   break;

                               case 11:
                                   num = "Queen";
                                   break;

                               case 12:
                                   num = "King";
                                   break;
                               

                            default:
                                num = string.Empty;
                                //num = (number + 1).ToString();
                                break;
                        }

                        switch (colour)
                        //Chosing colour
                        {
                            case 0:
                                Console.Write(String.Format("You draw {0} of Hearts.", num));
                                break;

                            case 1:
                                Console.Write(String.Format("You drew {0} of Diamonds.", num));
                                break;

                            case 2:
                                Console.Write(String.Format("You drew {0} of Spades.", num));
                                break;

                            case 3:
                                Console.Write(String.Format("You drew {0} of Clovers.", num));
                                break;
                            case 4:
                                Console.Write(String.Format("You drew {0} of Hearts.", num));
                                break;

                            case 5:
                                Console.Write(String.Format("You drew {0} of Diamonds.", num));
                                break;

                            case 6:
                                Console.Write(String.Format("You drew {0} of Spades.", num));
                                break;

                            case 7:
                                Console.Write(String.Format("You drew {0} of Clovers.", num));
                                break;


                        }
                        carddeck[colour, number] = false;
                        Cards--;
                        //All face cards set to 10
                        if (number > 9)
                        {
                            number = 9;
                        }
                        //Score counter
                        if (number == 0 && score < 11)
                        {
                            number = 10;
                        }
                        score = (number + 1) + score;

                        Console.WriteLine("Your score is {0} points!", score);
                        if (score > 21)
                        {
                            Console.WriteLine("You are full, better luck next time!");
                            score = 0;

                        }
                        if (score == 21)
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
