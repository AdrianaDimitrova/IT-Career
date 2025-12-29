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
        double kmForMonth = double.Parse(Console.ReadLine());
        double sumForKm = 0;

        //Action
        if (kmForMonth <= 500)
        {
            if (season == "Spring" || season == "Autumn")
            {
                sumForKm = 0.75;

            }
            else if (season == "Summer")
            {
                sumForKm = 0.90;
            }
            else if (season == "Winter")
            {
                sumForKm = 1.05;
            }
        }

        else if (kmForMonth <= 5000)
        {
            if (season == "Spring" && season == "Autumn")
            {
                sumForKm = 0.75;

            }
            else if (season == "Summer")
            {
                sumForKm = 0.90;
            }
            else if (season == "Winter")
            {
                sumForKm = 1.05;
            }

        }

        else if (kmForMonth <= 10000)
        {
            if (season == "Spring" || season == "Autumn")
            {
                sumForKm = 0.95;

            }
            else if (season == "Summer")
            {
                sumForKm = 1.10;
            }
            else if (season == "Winter")
            {
                sumForKm = 1.25;
            }

        }

        else if (kmForMonth <= 20000)
        {
            sumForKm = 1.45;
        }
        double Total = kmForMonth*sumForKm*4;
        Total *= 0.9;


        //OutPut
        Console.WriteLine($"{Total:f2}");

    }
}

