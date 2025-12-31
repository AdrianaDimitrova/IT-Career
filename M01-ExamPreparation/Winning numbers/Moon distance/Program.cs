using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        double speed = double.Parse(Console.ReadLine());
        double fuel100 = double.Parse(Console.ReadLine());

        double totalDistance = 2 * 384400;
        double time = Math.Ceiling(totalDistance / speed);

        double totalTime = time + 3;

        double fuel = (totalDistance * fuel100) / 100;

        Console.WriteLine($"{totalTime}");
        Console.WriteLine($"{fuel}");

    }
}

