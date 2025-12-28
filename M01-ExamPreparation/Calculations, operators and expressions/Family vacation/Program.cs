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
        double budget = double.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        double nightCost = double.Parse(Console.ReadLine());
        int addcosts = int.Parse(Console.ReadLine());

        //Action
        double nightPrice = nights * nightCost;

        if (nights > 7)
        {
            nightPrice *= 0.95;
        }

        double addcost = addcosts * budget/100;

        double TotalPrice = nightPrice + addcost;

        if (budget > TotalPrice)
        {
            Console.WriteLine($"Ivanovi will be left with {budget - TotalPrice:f2} leva after vacation.");
        }
        else
        {
            Console.WriteLine($"{Math.Abs(TotalPrice-budget):f2} leva needed.");
        }



    }
}

