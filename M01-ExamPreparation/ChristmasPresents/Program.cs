using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int children = int.Parse(Console.ReadLine());

            int lego = 0;
            int monopoly = 0;
            int puzzle = 0;
            int robot = 0;

            for (int i = 0; i < children; i++)
            {
                string present = Console.ReadLine();
                switch (present)
                {
                    case "lego":
                        lego++;
                        break;

                    case "monopoly":
                        monopoly++;
                        break;

                    case "puzzle":
                        puzzle++;
                        break;

                    case "robot":
                        robot++;
                        break;
                }
            }
            Console.WriteLine($"Lego: {((double)lego * 100 /children):f2}%");
            Console.WriteLine(($"Monopoly: {((double)monopoly *100/children):f2}%"));
            Console.WriteLine(($"Puzzle: {((double)puzzle * 100/children):f2}%"));
            Console.WriteLine(($"Robot: {((double)robot* 100/children):f2}%"));

        }
    }
}
