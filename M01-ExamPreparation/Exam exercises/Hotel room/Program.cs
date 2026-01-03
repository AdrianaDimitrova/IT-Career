using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        string season = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studioPrice=0;
        double apartmentPrice=0;

        if (season == "May" || season == "October")
        {
            studioPrice = 50.0;
            if (nights > 14)
            {
                studioPrice *= 0.70;
            }
            else if (nights > 7)
            {
                studioPrice *= 0.95;
            }

            apartmentPrice = 65.0;
            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }
        }

        else if (season == "June" || season == "September")
        {
            studioPrice = 75.20;
            if (nights > 14)
            {
                studioPrice *= 0.80;
            }
            apartmentPrice = 68.70;
            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }
        }

        else if (season == "July" || season == "August")
        {
            studioPrice = 76.0;
            apartmentPrice = 77.0;
            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }
        }
        double totalStudio = nights * studioPrice;
        double totalApartment = nights * apartmentPrice;

        Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
        Console.WriteLine($"Studio: {totalStudio:f2} lv.");
        
        
       



       
        

            
    }
}

