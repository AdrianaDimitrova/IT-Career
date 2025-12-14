using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_ChristmasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            int nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string roomType = Console.ReadLine();

            // Action 
            double price = 0.0;
            if (roomType == "double")
            {
                switch (destination)
                {
                    case "Borovets": price = 38; break;
                    case "Bansko": price = 35; break;
                    case "Pamporovo": price = 39; break;
                }

            }
            else if (roomType == "apartament")
            { 
                switch (destination)
                {
                    case "Borovets": price = 45; break;
                    case "Bansko": price = 42; break;
                    case "Pamporovo": price = 49; break;
                }
            }

            double totalPrice = price * nights;
            if (nights > 10)
            {
                totalPrice *= 0.85;
            }

            // Output
            Console.WriteLine($"They have to spend {totalPrice:f2} leva");
        }
    }
}
