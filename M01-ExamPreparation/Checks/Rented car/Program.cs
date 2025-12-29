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
        string season = Console.ReadLine();

        string typeClass = "";
        string typeCar = "";

        double price = 0.0;


        //Action
        if (budget <= 100)
        {
            typeClass = "Economy class";

            if (season == "Summer")
            {
                typeCar = "Cabrio";
                price = budget * 0.35;
            }

            else if (season == "Winter")
            {
                typeCar = "Jeep";
                price = budget * 0.65;

            }
        }

        else if (budget > 100 && budget <= 500)
        {
            typeClass = "Compact class";

            if (season == "Summer")
            {
                typeCar = "Cabrio";
                price = budget * 0.45;
            }

            else if (season == "Winter")
            {
                typeCar = "Jeep";
                price = budget * 0.80;

            }

        }

        else
        {
            typeClass = "Luxury class";
            typeCar = "Jeep";
            price = budget * 0.90;

        }

        //Output
        Console.WriteLine($"{typeClass}");
        Console.WriteLine($"{typeCar} - {price:f2}");

    }
}

