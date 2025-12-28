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
        int people = int.Parse(Console.ReadLine());
        double entrance = double.Parse(Console.ReadLine());
        double sunloungerPrice = double.Parse(Console.ReadLine());
        double umbrellaPrice = double.Parse(Console.ReadLine());

        //Action
        double entrancePrice = entrance * people;

        double sunlounderCount = Math.Ceiling(people * 0.75);
        double sunlounderTotalPrice = sunlounderCount * sunloungerPrice;

        double umbrellaCount = Math.Ceiling(people *0.50);
        double umbrellaTotalPrice = umbrellaPrice * umbrellaCount;

        double TotalPrice = entrancePrice + sunlounderTotalPrice + umbrellaTotalPrice;

        //Output
        Console.WriteLine($"{TotalPrice:f2} lv.");
    }
}

