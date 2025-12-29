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
        string season = Console.ReadLine();
        string groupType = Console.ReadLine();
        int students = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());

        string sport = "";
        double pricePerNight = 0;

        //Action
        if (season == "Winter")
        {
            if (groupType == "girls")
            {
                sport = "Gymnastics";
                pricePerNight = 9.60;
            }
            else if (groupType == "boys")
            {
                sport = "Judo";
                pricePerNight = 9.60;
            }
            else if(groupType=="mixed")
            {
                sport = "Ski";
                pricePerNight = 10.0;
            }

        }

        else if (season == "Spring")
        {
            if (groupType == "girls")
            {
                sport = "Athletics";
                pricePerNight = 7.20;
            }
            else if (groupType == "boys")
            {
                sport = "Tennis";
                pricePerNight = 7.20;
            }
            else if (groupType == "mixed")
            {
                sport = "Cycling";
                pricePerNight = 9.50;
            }

        }

        else if (season == "Summer")
        {
            if (groupType == "girls")
            {
                sport = "Volleyball";
                pricePerNight = 15.0;
            }
            else if (groupType == "boys")
            {
                sport = "Football";
                pricePerNight = 15.0;
            }
            else if (groupType == "mixed")
            {
                sport = "Swimming";
                pricePerNight = 20.0;
            }

        }

        double totalPriceNights = pricePerNight * nights*students;

        if (students >= 50)
        {
            totalPriceNights *= 0.5;
        }

        else if (students >= 20)
        {
            totalPriceNights *= 0.85;
        }

        else if (students >= 10)
        {
            totalPriceNights *= 0.95;
        }

        Console.WriteLine($"{sport} {totalPriceNights:f2} lv.");


    }
}

