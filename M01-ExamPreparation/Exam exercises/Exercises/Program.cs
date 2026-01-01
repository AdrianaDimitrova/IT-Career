using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        //Input
        int km = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();

        double price = 0.0;

        if (km >= 100)
        {
            price = 0.06 * km;
        }
        else if (km >= 20 && km < 100)
        {
            price = 0.09 * km;

        }
        else
        {
            if (timeOfDay == "day")
            {
                price = 0.79 * km + 0.70;
            }
            else if (timeOfDay == "night")
            {
                price = 0.90 * km + 0.70;
            }
        }
        Console.WriteLine($"{price:f2}");


    }
}

