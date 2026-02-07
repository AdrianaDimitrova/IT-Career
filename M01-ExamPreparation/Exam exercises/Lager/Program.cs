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
        int nights = int.Parse(Console.ReadLine());
        string destination = Console.ReadLine();
        string roomType = Console.ReadLine();
        string packetType = Console.ReadLine();

        double price = 0.0;
        //Action
        switch (destination)
        {
            case "Mountain":
                if (roomType == "standard")
                {
                    price = 80.0;
                }
                else if(roomType=="cabin")
                {
                    price = 140.0;
                }
                break;

            case "Sea":
                if (roomType == "standard")
                {
                    price = 110.0;
                }
                else if (roomType == "cabin")
                {
                    price = 180.0;
                }
                break;

            case "City":
                if (roomType == "standard")
                {
                    price = 90.0;
                }
                else if (roomType == "cabin")
                {
                    price = 160.0;
                }
                break; 
        }

        double totalPrice = price * nights;

        if (packetType == "plus")
        {
            totalPrice *= 1.20;
        }
        else if (packetType == "premium")
        {
            totalPrice *= 1.40;
        }
        Console.WriteLine($"{totalPrice:f2}");
    }
}

