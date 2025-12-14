using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_ChristmasPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int children = int.Parse(Console.ReadLine());
            int lego = 0;
            int monopoly = 0;
            int puzzles = 0;
            int robots = 0;

            // Action

            for (int i = 0; i < children; i++)
            {
                string precents = Console.ReadLine();

                switch (precents)
                {
                    case "lego": lego++;  break;
                    case "puzzle": puzzles++; break;
                    case "monopoly": monopoly++;  break;
                    case "robot": robots++;  break;
                }
            }

            // Outbut 
            Console.WriteLine($"Lego: {lego/(double)children *100:f2}%");
            Console.WriteLine($"Monopoly: {monopoly/(double)children * 100:f2}%");
            Console.WriteLine($"Puzzles: {puzzles / (double)children * 100:f2}%");
            Console.WriteLine($"Robots: {robots/(double)children*100:f2}%");




        }
    }
}
