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

        double price = 0;
        //Action
        switch (destination)
        {
            case "Paris":
                if (roomType == "double room")
                {
                    price = 150;
                }
                else if (roomType == "apartment")
                {
                    price = 300;
                }
                if (packetType == "all-inclusive")
                {
                    price *= 1.30;
                }
                else if (packetType == "ultra-all-inclusive")
                {
                    price *= 1.50;
                }
                    break;

            case "Phuket":
                if (roomType == "double room")
                {
                    price = 250;
                }
                else if (roomType == "apartment")
                {
                    price = 360;
                }
                if (packetType == "all-inclusive")
                {
                    price *= 1.30;
                }
                else if (packetType == "ultra-all-inclusive")
                {
                    price *= 1.50;
                }
                break;

            case "Mexico":
                if (roomType == "double room")
                {
                    price = 220;
                }
                else if (roomType == "apartment")
                {
                    price = 310;
                }
                if (packetType == "all-inclusive")
                {
                    price *= 1.30;
                }
                else if (packetType == "ultra-all-inclusive")
                {
                    price *= 1.50;
                }
                break;


        }
        double totalPrice = price * nights;
        Console.WriteLine($"{totalPrice:f2}");
    }
}

