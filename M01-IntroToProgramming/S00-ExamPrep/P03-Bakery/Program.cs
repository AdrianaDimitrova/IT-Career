using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double breadPrice = double.Parse(Console.ReadLine());
            int breadCount = int.Parse(Console.ReadLine());
            int sweetBreadCount = int.Parse(Console.ReadLine());
            int bagelCount = int.Parse(Console.ReadLine());
            int croasaniCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            // Action 
            double sweetBreadPrice = breadPrice * 1.2;
            double bagelPrice = sweetBreadCount * 0.6;
            double croasanPrice = sweetBreadPrice + 1.2;

            // Output 

            double totalPrice = (sweetBreadPrice * sweetBreadCount) + (bagelPrice*bagelCount) + (croasanPrice*croasaniCount);
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Yes! {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No! {totalPrice-budget:f2} leva need.");
            }

        }
    }
}
