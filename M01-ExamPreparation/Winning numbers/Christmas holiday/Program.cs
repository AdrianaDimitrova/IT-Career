using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int nights = int.Parse(Console.ReadLine());
        string destination = Console.ReadLine();
        string roomType = Console.ReadLine();
        double price = 0;

        if (destination == "Borovets")
        {
            if (roomType == "double")
            {
                price = 38;
            }
            else if (roomType == "apartment")
            {
                price = 45;
            }
        }
        else if (destination == "Bansko")
        {
            if (roomType == "double")
            {
                price = 35;
            }
            else if (roomType == "apartment")
            {
                price = 42;
            }
        }
        else if (destination == "Pamporovo")
        {
            if (roomType == "double")
            {
                price = 39;
            }
            else if (roomType == "apartment")
            {
                price = 49;
            }
        }
        double totalPrice = nights * price;
        if (nights >= 10)
        {
            totalPrice *= 0.85;
        }
        Console.WriteLine($"They have to spend {totalPrice:f2} leva.");

    }
}

