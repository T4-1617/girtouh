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
            int Cards = 208;
            int score = 0;
            while (Cards >0)
            {

                //Computer draws cards
                Console.WriteLine("Dealer draws.");
                string numbers;
                int colour = draw.Next(0, 8);
                int number = draw.Next(0, 26);
                //Searches for undrawn cards
                while(carddeck[colour,number]==false)
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
                            numbers = "Ace";
                            break;

                        case 10:
                            numbers = "Jack";
                            break;

                        case 11:
                            numbers = "Queen";
                            break;

                        case 12:
                            numbers = "King";
                            break;

                        case 13:
                            numbers = "Ace";
                            break;

                        case 23:
                            numbers = "Jack";
                            break;

                        case 24:
                            numbers = "Queen";
                            break;

                        case 25:
                            numbers = "King";
                            break;

                        default:
                            numbers = string.Empty;
                            if (number >12)
                            {
                                number =(number- 10);
                            }
                            numbers = (number + 1).ToString();
                            break;
                    }
                switch (colour)
                    //Specifying the number of drawn card
                    {
                        case 0:
                            Console.Write(String.Format("You drew {0} of Hearts", numbers));
                            break;

                        case 1:
                            Console.Write(String.Format("You drew {0} of Hearts", numbers));
                            break;

                        case 2:
                            Console.Write(String.Format("You drew {0} of Spades", numbers));
                            break;

                        case 3:
                            Console.Write(String.Format("You drew {0} of Spades", numbers));
                            break;

                        case 4:
                            Console.Write(String.Format("You drew {0} of Diamonds", numbers));
                            break;

                        case 5:
                            Console.Write(String.Format("You drew {0} of Diamonds", numbers));
                            break;

                        case 6:
                            Console.Write(String.Format("You drew {0} of Clovers", numbers));
                            break;

                        case 7:
                            Console.Write(String.Format("You drew {0} of Clovers", numbers));
                            break;

                    }
                    carddeck[colour, number] = false;
                    Cards--;

                    }

            }
        }
    }
}
