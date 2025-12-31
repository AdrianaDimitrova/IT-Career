using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        string sector = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int seats = int.Parse(Console.ReadLine());

        double sectorAPrice = 11.6;
        double sectorBPrice = 14.5;
        double sectorCPrice = 16.10;
        double sectorDPrice = 8.40;

        double totalPrice = 0;

        int totalSeats = seats * rows;

        if (sector == "Sector A")
        {
            totalPrice = totalSeats * sectorAPrice;
            Console.WriteLine($"{totalPrice:f2}  lv.");
        }

        else if (sector == "Sector B")
        {
            totalPrice = totalSeats * sectorBPrice;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }

        else if (sector == "Sector C")
        {
            totalPrice = totalSeats * sectorCPrice;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }

        else if (sector == "Sector D")
        {
            totalPrice = totalSeats * sectorDPrice;
            Console.WriteLine($"{totalPrice:f2} lv. ");
        }
       


    }
}

