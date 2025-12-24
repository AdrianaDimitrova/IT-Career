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
        double speed = double.Parse(Console.ReadLine());
        double fuelFor100Km = double.Parse(Console.ReadLine());

        //Action
        double totalDistance = 384400 * 2;
        double time = (Math.Ceiling(totalDistance / speed));
        double totalTime = time + 3;
        double totalFuel = (fuelFor100Km * totalDistance) /100;

        // Output
        Console.WriteLine($"Броят на часовете, за които Георги е отишъл и се е върнал: {totalTime:f2} часа ");
        Console.WriteLine($"Количеството литри гориво, което е нужно за пътуването: {totalFuel} литра");

    }
}

