﻿using System;
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
                    if (Gamemap[x, y] == true)
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

               
                /*Potential updates: 
                                    I
                                    I
                                    V
                Adds boats depending on written value
                Console.WriteLine("Write number of boats:");
            string amountB = Console.ReadLine();
            for (int i = 3; i < 6; i++)
            {
                
            }*/
            }
        }
    }
}
