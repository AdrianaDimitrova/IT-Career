using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        double breadPrice = double.Parse(Console.ReadLine());
        int breadCount = int.Parse(Console.ReadLine());
        int sweetbreadCount = int.Parse(Console.ReadLine());
        int bagelCount = int.Parse(Console.ReadLine());
        int croissant = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        double sweetbreadPrice = breadPrice * 1.2;
        double bagelPrice = sweetbreadPrice * 0.6;
        double croissantPrice = bagelPrice + 1.2;

        double totalPrice = sweetbreadPrice + bagelPrice + croissantPrice;

        if (budget > totalPrice)
        {
            Console.WriteLine($"Yes! {budget - totalPrice:f2} leva left.");
        }
        else if (budget < totalPrice)
        {
            Console.WriteLine($"No! {totalPrice-budget:f2} leva needed.");
        }
        

    }
}

