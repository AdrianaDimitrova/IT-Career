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
        string month = Console.ReadLine();
        int hours = int.Parse(Console.ReadLine());
        int people = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();

        double price = 0;

        //Action
        switch (month)
        {
            case "march":
                if (dayTime == "day")
                {
                    price = 10.50;
                }
                else if (dayTime == "night")
                {
                    price = 8.40;
                }
                break;

            case "april":
                if (dayTime == "day")
                {
                    price = 10.50;
                }
                else if (dayTime == "night")
                {
                    price = 8.40;
                }
                break;

            case "may":
                if (dayTime == "day")
                {
                    price = 10.50;
                }
                else if (dayTime == "night")
                {
                    price = 8.40;
                }
                break;

            case "june":
                if (dayTime == "day")
                {
                    price = 12.60;
                }
                else if (dayTime == "night")
                {
                    price = 10.20;
                }
                break;

            case "july":
                if (dayTime == "day")
                {
                    price = 12.60;
                }
                else if (dayTime == "night")
                {
                    price = 10.20;
                }
                break;

            case "august":
                if (dayTime == "day")
                {
                    price = 12.60;
                }
                else if (dayTime == "night")
                {
                    price = 10.20;
                }
                break;
        }

        if (people >= 4)
        {
            price *= 0.90;
        }
        if (hours >= 5)
        {
            price *= 0.50;
        }

        double total = price * people * hours;

        Console.WriteLine($"Price per person for one hour: {price:f2}");
        Console.WriteLine($"Total cost of the visit: {total:f2}");

    }
}

