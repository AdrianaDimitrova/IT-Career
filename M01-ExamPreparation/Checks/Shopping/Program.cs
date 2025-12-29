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
        int videoCardsCount = int.Parse(Console.ReadLine());
        int processorsCount = int.Parse(Console.ReadLine());
        int RAMCount = int.Parse(Console.ReadLine());

        //Action
        double videoCardPrice = videoCardsCount* 250;
        double processorPrice = videoCardPrice * 0.35;
        double RAMPrice = videoCardPrice * 0.1;

        double TotalPrice = videoCardPrice+ processorPrice*processorsCount + RAMPrice*RAMCount;
        if (videoCardsCount > processorsCount)
        {
            TotalPrice *= 0.85;
        }

        //Output
        if (budget > TotalPrice)
        {
            Console.WriteLine($"You have {budget - TotalPrice:f2} leva left!");
        }
        else if(TotalPrice>budget)
        {
            Console.WriteLine($"Not enough money! You need {TotalPrice-budget:f2} leva more!");
        }

    }
}

