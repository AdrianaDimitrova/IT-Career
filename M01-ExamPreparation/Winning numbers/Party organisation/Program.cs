using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int decorationPrice = int.Parse(Console.ReadLine());

        double pizzaPrice = 2 * decorationPrice;
        double drinksPrice = pizzaPrice * 0.85;
        double boardGamesPrice = (pizzaPrice + drinksPrice) / 7;

        double totalPrice = decorationPrice + pizzaPrice + drinksPrice + boardGamesPrice;
        Console.WriteLine($"{totalPrice:f2}");


    }
}

