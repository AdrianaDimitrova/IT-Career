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
        string typeGame = Console.ReadLine();
        string typeTicket = Console.ReadLine();
        int ticketsCount = int.Parse(Console.ReadLine());
        string photo = Console.ReadLine();

        double photoPrice = 0.0;
        double price = 0;

        //Action
        if (typeGame == "Quarter final")
        {
            switch (typeTicket)
            {
                case "Standart":
                    price = 55.50;
                    break;

                case "Premium":
                    price = 105.20;
                    break;

                case "VIP":
                    price = 118.90;
                    break;
            }

        }

        else if (typeGame == "Semi final")
        {
            switch (typeTicket)
            {
                case "Standart":
                    price = 75.88;
                    break;

                case "Premium":
                    price = 125.22;
                    break;

                case "VIP":
                    price = 160.66;
                    break;
            }
        }

        else if (typeGame == "Final")
        {
            switch (typeTicket)
            {
                case "Standart":
                    price = 110.10;
                    break;

                case "Premium":
                    price = 160.66;
                    break;

                case "VIP":
                    price = 400.0;
                    break;
            }
        }

        double totalPrice = price * ticketsCount;

        if (photo == "Y" && totalPrice <= 4000)
        {
            photoPrice += 40;
        }

        if (totalPrice > 4000)
        {
            totalPrice *= 0.75;
        
        }

        else if (totalPrice > 2500)
        {
            totalPrice *= 0.90;
        }

        totalPrice += photoPrice;

        Console.WriteLine($"{totalPrice:f2}");





    }
}

