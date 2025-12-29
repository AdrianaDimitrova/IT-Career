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
        string fuelType = Console.ReadLine();
        double quantityFuel = double.Parse(Console.ReadLine());
        string clubCard = Console.ReadLine();

        double price = 0;

        //Action
        if (fuelType == "Gas")
        {
            price = 0.93;

            if (clubCard == "Yes")
            {
                price -= 0.08;
            }

        }

        else if (fuelType == "Gasoline")
        {
            price = 2.22;

            if (clubCard == "Yes")
            {
                price -= 0.18;
            }

        }

        else if (fuelType == "Diesel")
        {
            price = 2.33;

            if (clubCard == "Yes")
            {
                price -= 0.12;
            }

        }

        double totalPrice = price * quantityFuel;

        if (quantityFuel > 20 && quantityFuel <= 25)
        {
            totalPrice *= 0.92;
        }
        else if (quantityFuel > 25)
        {
            totalPrice *= 0.90;
        }

        //Output
        Console.WriteLine($"{totalPrice:f2} lv. ");

    }
}

