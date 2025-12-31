using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        int children = int.Parse(Console.ReadLine());
        double lego = 0;
        double monopoly = 0;
        double puzzle = 0;
        double robot = 0;

        for (int i = 1; i <= children; i++)
        {
            string present = Console.ReadLine();

            if (present == "lego")
            {
                lego++;
            }
            if (present == "monopoly")
            {
                monopoly++;
            }
            if (present == "puzzle")
            {
                puzzle++;

            }
            if (present == "robot")
            {
                robot++;
            }
            

        }
        Console.WriteLine($"Lego {lego / children * 100:f2}% ");
        Console.WriteLine($"Monopoly {monopoly / children *100:f2}%");
        Console.WriteLine($"Puzzles {puzzle / children * 100:f2}%");
        Console.WriteLine($"Robots {robot / children * 100:f2} %");

    }
}

