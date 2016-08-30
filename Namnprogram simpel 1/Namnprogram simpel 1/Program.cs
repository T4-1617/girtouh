using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namnprogram_simpel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du i förnman? Skriv och klicka enter.");
            string name = Console.ReadLine();
            Console.WriteLine("Ok, och vad heter du i efternamn?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Ok. Hej " + lastname + "! Trevligt att träffas!");
            Console.ReadLine();
        }
    }
}
