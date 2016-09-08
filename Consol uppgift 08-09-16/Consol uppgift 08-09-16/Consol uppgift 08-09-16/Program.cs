using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_uppgift_08_09_16
{
    class Program
    {
        private static bool[,] carddeck = new bool[8, 26];
        static void Main(string[] args)
        {
            //Added carddeck restrictions


            for (int number = 0; number < 26; number++)
            {
                for (int colour = 0; colour < 8; colour++)
                {
                    carddeck[colour, number] = true;
                }
            }
            //Stating variables
            Random draw = new Random();
            int points = 0;
            int Cards = 208;
            int DealerScore = 0;
            int score = 0;
            bool draworno = true;

            while (Cards > 0)
            {
                while (Cards > 10)
                {
                    bool dealerdraw = false;

                    //Computer draws first card
                    Console.Write("Dealer");
                    int number = Drawingcard();


                    //Removes drawn card from carddeck

                    Cards--;
                    //Setting facecards to 10 and Ace to 1 or 11 depending on score
                    if (number > 9)
                    {
                        number = 9;
                    }
                    if (number == 0 && number == 13 && DealerScore < 11)
                    {
                        number = 10;
                    }
                    if (number == 0 && DealerScore < 11)
                    {
                        number = 10;
                    }


                    DealerScore = (number + 1) + DealerScore;
                    Console.WriteLine("Dealers score is {0}.", DealerScore);


                    while (draworno == true)
                    {
                        //Player choise
                        Console.WriteLine("Would you like a card?(Y/N)");
                        string yesorno = Console.ReadLine();
                        Console.WriteLine(Cards);
                        if (yesorno == "y")
                        {
                            Console.Write("You");
                            //Player draws a card
                            int Pnumber = Drawingcard();

                            //Removes playerdrawn card from carddeck
                            Cards--;
                            //Setting facecards to 10 and Ace to 1 or 11 depending on score
                            if (Pnumber > 9)
                            {
                                Pnumber = 9;
                            }
                            if (Pnumber == 0 && Pnumber == 13 && score < 11)
                            {
                                Pnumber = 10;
                            }
                            if (Pnumber == 0 && score < 11)
                            {
                                Pnumber = 10;
                            }
                            score = (Pnumber + 1) + score;

                        }
                        else if (yesorno == "n")
                        {
                            draworno = false;
                            dealerdraw = true;
                        }
                        else
                        {
                            Console.WriteLine("Please write y or n");

                        }
                        Console.WriteLine("Your score is {0}!", score);
                        Console.ReadLine();

                        //If player score is 21
                        if (score == 21)
                        {
                            Console.WriteLine("You win, you got 3 points!");
                            points = points + 3;
                            DealerScore = 0;
                            score = 0;
                            Console.WriteLine("You have {0} points!", points);
                            draworno = false;
                            dealerdraw = false;

                        }

                        //If player score is too high
                        if (score > 21)
                        {
                            Console.WriteLine("You are full, you lost a point");
                            points = points - 1;
                            DealerScore = 0;
                            score = 0;
                            Console.WriteLine("You have {0} points!", points);
                            draworno = false;
                            dealerdraw = false;
                        }


                    }



                    while (dealerdraw)
                    {
                        //Computer draws more card
                        Console.Write("Dealer");
                        number = Drawingcard();


                        //Removes the drawn cards from carddeck
                        Cards--;

                        //Setting facecards to 10 and Ace to 1 or 11 depending on score
                        if (number > 9)
                        {
                            number = 9;
                        }

                        if (number == 0 && number == 13 && DealerScore < 11)
                        {
                            number = 10;
                        }

                        if (number == 0 && DealerScore < 11)
                        {
                            number = 10;
                        }


                        DealerScore += number + 1;
                        Console.WriteLine("Dealers score is {0}.", DealerScore);

                        //Dealer get 21 points
                        if (DealerScore == 21)
                        {
                            Console.WriteLine("Dealer wins, you lost a point!");
                            points = points - 1;

                            Console.WriteLine("You have {0} points!", points);
                            dealerdraw = false;
                        }
                        //Dealer is full
                        else if (DealerScore > 21)
                        {
                            Console.WriteLine("Dealer is full, you got a point!!");
                            points = points + 1;
                            Console.WriteLine("You have {0} points!", points);
                            dealerdraw = false;
                        }
                        //Dealer have more points
                        else if (DealerScore >= score)
                        {
                            Console.WriteLine("Dealer wins, you lost a point!");
                            points = points - 1;
                            Console.WriteLine("You have {0} points!", points);
                            dealerdraw = false;

                        }

                    }

                    draworno = true;
                    DealerScore = 0;
                    score = 0;
                }

                Console.WriteLine("Carddeck almost empty, shuffling deck!");
                Cards = 208;
            }


        }
        //"Carddrawing" funktion
        private static int Drawingcard()
        {
            Random draw = new Random();
            int colour = draw.Next(0, 8);
            int number = draw.Next(0, 26);
            while (carddeck[colour, number] == false)
            {
                colour = draw.Next(0, 8);
                number = draw.Next(0, 26);
            }
            if (carddeck[colour, number] == true)
            {
                string numberS;
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
                        Console.Write(" drew {0} of Hearts. ", numberS);
                        break;

                    case 1:
                        Console.Write(" drew {0} of Hearts. ", numberS);
                        break;

                    case 2:
                        Console.Write(" drew {0} of Spades. ", numberS);
                        break;

                    case 3:
                        Console.Write(" drew {0} of Spades. ", numberS);
                        break;

                    case 4:
                        Console.Write(" drew {0} of Diamonds. ", numberS);
                        break;

                    case 5:
                        Console.Write(" drew {0} of Diamonds. ", numberS);
                        break;

                    case 6:
                        Console.Write(" drew {0} of Clovers. ", numberS);
                        break;

                    case 7:
                        Console.Write(" drew {0} of Clovers. ", numberS);
                        break;

                }
            }
            carddeck[colour, number] = false;
            return number;
        }
    }
}
