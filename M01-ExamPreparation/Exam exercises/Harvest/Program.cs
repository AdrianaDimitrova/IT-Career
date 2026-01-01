using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int wineyard = int.Parse(Console.ReadLine());
        double grapes = double.Parse(Console.ReadLine());
        double wine = double.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double totalGrapes = wineyard * grapes;
        double totalWine = 0.4 * totalGrapes / 2.5;
        double wineleft = totalWine - wine;

        if (totalWine < wine)
        {
            Console.WriteLine($"It will be a tough winter! More {(int)Math.Floor(wine - totalWine)} liters wine needed.");
        }
        else 
        {
            Console.WriteLine($"Good harvest this year! Total wine: {(int)Math.Floor(totalWine)} liters.");
            Console.WriteLine($"{(int)Math.Ceiling(wineleft)} liters left -> {(int)Math.Ceiling(wineleft/workers)} liters per person.");
        }
         
    }
}

