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
        string fuel = Console.ReadLine();
        double liters = double.Parse(Console.ReadLine());

        //Action
        if (fuel != "Gas" && fuel != "Gasoline" && fuel != "Diesel")
        {
            Console.WriteLine($"Invalid fuel!");
        }
        else if (liters >= 25)
        {
            Console.WriteLine($"You have enough {fuel}.");
        }
        else 
        {
            Console.WriteLine($"Fill your tank with {fuel}!");
        }


    }
}

