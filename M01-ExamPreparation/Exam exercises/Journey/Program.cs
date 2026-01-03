using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination="";
        string vacantionType="";
        double price = 0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                vacantionType = "Camp";
                price = budget * 0.3;
            }
            else if (season == "winter")
            {
                vacantionType = "Hotel";
                price = budget * 0.7;
            }
        }

        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                vacantionType = "Camp";
                price = budget * 0.4;
            }
            else if (season == "winter")
            {
                vacantionType = "Hotel";
                price = budget * 0.8;
            }
        }

        else if (budget > 1000)
        {
            destination = "Europe";
            vacantionType = "Hotel";
            price = budget * 0.9;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{vacantionType} – {price}");

    }
}

