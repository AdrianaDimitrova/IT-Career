using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


public class Program
{
    public static void Main(string[] args)
    {
        //Input
        string sector = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int seats = int.Parse(Console.ReadLine());
        double price = 0.0;
        int totalSeats = 0;

        //Action
        switch (sector)
        {
            case "Sector A":
                price = 11.60;
                totalSeats = rows * seats;
                break;

            case "Sector B":
                price = 14.50;
                totalSeats = rows * seats;
                break;

            case "Sector C":
                price = 16.10;
                totalSeats = rows * seats;
                break;

            case "Sector D":
                price = 8.40;
                totalSeats = rows * seats;
                break;
        }
        double pechalba = totalSeats * price;
        Console.WriteLine($"The profit from the sector is {pechalba} lv.");
        






    }
}
