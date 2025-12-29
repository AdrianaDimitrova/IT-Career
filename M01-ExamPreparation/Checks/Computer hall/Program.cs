using System;
using System.Collections.Generic;
using System.Globalization;
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
        string timeOfDay = Console.ReadLine();

        double price = 0;

        //Action
        if (month == "March" || month == "April" || month == "May")
        {

            if (timeOfDay == "day")
            {
                price = 10.50;

            }

            else if (timeOfDay == "night")
            {
                price = 8.40;
            }
        }

        else if (month == "June" || month == "July" || month == "August")
        {
            if (timeOfDay == "day")
            {
                price = 12.60;
            }
            else if (timeOfDay == "night")
            {
                price = 10.20;

            }

        }

        if (people >= 4)
        {
            price *= 0.9;
        }

        if (hours >= 5)
        {
            price *= 0.5;
        }

        //Output
        Console.WriteLine($"Price per person for one hour: {price:f2}");

        double TotalPrice = price * people * hours;
        Console.WriteLine($"Total cost of the visit: {TotalPrice:f2}");

    }
}

