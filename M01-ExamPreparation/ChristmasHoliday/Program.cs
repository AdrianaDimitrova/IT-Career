using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string roomType = Console.ReadLine();
            double pricepernight = 0.0;
  
            //Action
            switch (destination)
            {
                case "Borovets":
                    if (roomType == "double")
                    {
                        pricepernight = 38.0;
                    }
                    else if (roomType == "apartment")
                    {
                        pricepernight = 45.0;
                    }
                    break;

                case "Bansko":
                    if (roomType == "double")
                    {
                        pricepernight = 35.0;
                    }
                    else if (roomType == "apartment")
                    {
                        pricepernight = 42.0;
                    }
                    break;

                case "Pamporovo":
                    if (roomType == "double")
                    {
                        pricepernight = 39.0;
                    }
                    else if (roomType == "apartment")
                    {
                        pricepernight = 49.0;
                    }
                    break;
            }
            double totalPrice = pricepernight * nights;

            if (nights > 10)
            {
                totalPrice *= 0.85;
            }
            Console.WriteLine($"They have to spend {totalPrice} leva.");
            

            

        }
    }
}
