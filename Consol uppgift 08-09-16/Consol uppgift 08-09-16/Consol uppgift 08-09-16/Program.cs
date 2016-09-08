using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_uppgift_08_09_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added carddeck restrictions
            bool[,] carddeck = new bool[8, 26];

            for (int number = 0; number < 26; number++)
            {
                for (int colour = 0; colour < 8; colour++)
                {
                    carddeck[colour, number] = true;
                }
            }
            //Drawing "Phase"
            Random draw = new Random();
            int points = 0;
            int Cards = 208;
            int DealerScore = 0;
            int score = 0;

            while (Cards > 0)
            {

                //Computer draws cards
                Console.WriteLine("Dealer draws.");
                string numberS;
                int colour = draw.Next(0, 8);
                int number = draw.Next(0, 26);
                //Searches for undrawn cards
                while (carddeck[colour, number] == false)
                {
                    colour = draw.Next(0, 8);
                    number = draw.Next(0, 26);
                }
                if (carddeck[colour, number] == true)
                {
                    //Specifying the number of drawn card
                    switch (number)
                    {
                        case 0:
                            numberS = "Ace";
                            break;

                        case 10:
                            numberS = "Jack";
                            break;

                        case 11:
                            numberS = "Queen";
                            break;

                        case 12:
                            numberS = "King";
                            break;

                        case 13:
                            numberS = "Ace";
                            break;

                        case 23:
                            numberS = "Jack";
                            break;

                        case 24:
                            numberS = "Queen";
                            break;

                        case 25:
                            numberS = "King";
                            break;

                        default:
                            numberS = string.Empty;
                            if (number > 12)
                            {
                                number = (number - 10);
                            }
                            numberS = (number + 1).ToString();
                            break;
                    }
                    switch (colour)
                    //Specifying the number of drawn card
                    {
                        case 0:
                            Console.Write(String.Format("Dealer drew {0} of Hearts. ", numberS));
                            break;

                        case 1:
                            Console.Write(String.Format("Dealer drew {0} of Hearts. ", numberS));
                            break;

                        case 2:
                            Console.Write(String.Format("Dealer drew {0} of Spades. ", numberS));
                            break;

                        case 3:
                            Console.Write(String.Format("Dealer drew {0} of Spade. s", numberS));
                            break;

                        case 4:
                            Console.Write(String.Format("Dealer drew {0} of Diamonds. ", numberS));
                            break;

                        case 5:
                            Console.Write(String.Format("Dealer drew {0} of Diamonds. ", numberS));
                            break;

                        case 6:
                            Console.Write(String.Format("Dealer drew {0} of Clovers. ", numberS));
                            break;

                        case 7:
                            Console.Write("Dealer drew {0} of Clovers. ", numberS);
                            break;

                    }
                    //Removes drawn card from carddeck
                    carddeck[colour, number] = false;
                    Cards--;
                    //Setting facecards to 10 and Ace to 1 or 11 depending
                    if (number > 9)
                    {
                        number = 10;
                    }
                    if (number == 0 && DealerScore < 11)
                    {
                        number = 10;
                    }
                    if (number == 0 && score < 11)
                    {
                        number = 10;
                    }
                    score = (number + 1) + score;
                    carddeck[colour, number] = false;
                    DealerScore = (number + 1) + DealerScore;
                    Console.WriteLine("Dealers score is {0}.", DealerScore);

                    //Nonbeneficial endings
                    if (DealerScore == 21)
                    {
                        Console.WriteLine("Dealer wins, you lost a point!");
                        points = points - 1;
                        DealerScore = 0;
                        score = 0;
                    }
                    if (DealerScore > score)
                    {
                        Console.WriteLine("Dealer wins, you lost a point!");
                        points = points - 1;
                        DealerScore = 0;
                        score = 0;
                    }
                    if (score>21)
                    {
                        Console.WriteLine("You are full, you lost a point");
                        points = points - 1;
                        DealerScore = 0;
                        score = 0;
                    }

                    //Beneficial endings
                    if (DealerScore > 21)
                    {
                        Console.WriteLine("Dealer is full, you got a point!!");
                        points = points + 1;
                        DealerScore = 0;
                        score = 0;
                    }

                    if (score == 21)
                    {
                        Console.WriteLine("You win, you got 3 points!");
                        points = points + 1;
                        DealerScore = 0;
                        score = 0;
                    }


                    Console.WriteLine("Your score is {0}!", score);
                    Console.ReadLine();
                }

                Console.WriteLine("Would you like a card?(Y/N)");
                string yesorno = Console.ReadLine();
                //Card counter
                Console.WriteLine(Cards);
                if (yesorno == "y")
                {

                }
            }
        }
    }
}
