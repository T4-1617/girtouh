using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_uppgift_02_09_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added bool
            bool[,] Gamemap = new bool[7, 5];

            //Added starting value
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    Gamemap[x, y] = false;
                }
            }

            //Creating gamemap

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    string f;
                    if (Gamemap[x, y])
                    {
                        f = "x";
                    }
                    if (Gamemap[x, y] == false)
                    {
                        f = "0";
                        Console.Write(f);
                    }

                }
                Console.WriteLine();
            }

            //Task which randomizes locations of boats.
            Random boat = new Random();
            int Boats = 0;
            int boats_on_map = 3;
            while (Boats < boats_on_map)
            {
                int x = boat.Next(0, 7);
                int y = boat.Next(0, 5);


                //Added lock to one boat for each potential space.
                if (Gamemap[x, y] == false)
                {

                    Console.WriteLine("Boat added at {0}, {1}", x, y);
                    Console.WriteLine(" ");
                    Gamemap[x, y] = true;
                    Boats++;
                    
                }
            }
            while (boats_on_map > 0)
            {
                Console.WriteLine("Enter x value");
                int shotX = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter y value");
                int shotY = int.Parse(Console.ReadLine());


                if (Gamemap[shotX, shotY] == true)
                {
                    Console.WriteLine("Hit boat at {0}, {1}.",shotX,shotY);
                    Console.ReadLine();
                }
                if (Gamemap[shotX, shotY]== false)
                {
                    Console.WriteLine("Miss at {0}, {1}.", shotX, shotY);
                    Console.ReadLine();
                }
            }


            /*
                    Console.WriteLine("Search with numbers on (x,y)");
                    string search = Console.ReadLine();
                    if (search =x, y )*/



            /*Potential updates: 
                                I
                                I
                                V
            Adds boats depending on written value
            Console.WriteLine("Write number of boats:");
        string amountB = Console.ReadLine();
        while (Boats < amountB);
        {

        }*/


        }
    }
}

