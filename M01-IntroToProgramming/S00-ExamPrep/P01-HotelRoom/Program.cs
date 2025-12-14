using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    const decimal MayOctoberStudio = 50m;
    const decimal MayOctoberApartament = 65m;
    const decimal JuneseptemberStudio = 75.20m;
    const decimal JuneseptemberApartament = 68.70m;
    const decimal JulyAugustStudio = 76m;
    const decimal JulyAugustApartament = 77m;
    public static void Main(string[] args)
    {
        // Input
        string month = Console.ReadLine();
        int days = int.Parse(Console.ReadLine());

        // Action
        decimal priceStudio = 0.0m;
        decimal priceapartament = 0.0m;
        switch (month)
        {
            case "May":
            case "October":
                priceStudio = MayOctoberStudio;
                if (days > 7 && days<=14)
                {
                    priceStudio *= 0.95m;
                    priceStudio *= 0.7m;
                }
                priceapartament = MayOctoberApartament;
                
                break;

            case "June":
            case "September":
                priceStudio = JuneseptemberStudio;
                if (days > 14)
                {
                    priceStudio *= 0.8m;
                }
                priceapartament = JuneseptemberApartament;
                break;

            case "July":
            case "August":
                priceStudio = JulyAugustStudio;
                priceapartament = JulyAugustApartament;
                break;
        }

        if (days > 14)
        {
            priceapartament *= 0.9m;
        }

        // Output
        decimal TotalPrceStudio = days * priceStudio;
        decimal TotalPrceApartment = days * priceapartament;

        Console.WriteLine($"Apartment: {TotalPrceApartment:f2} lv.”");
        Console.WriteLine($"Studio: {TotalPrceStudio:f2} lv.");
    }
}

