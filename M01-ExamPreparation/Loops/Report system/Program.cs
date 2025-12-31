using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int expectedSum = int.Parse(Console.ReadLine());
        int collectedSum = 0;

        double cashPay = 0;
        int cashCount = 0;
        double cardPay = 0;
        int cardCount = 0;

        int transactionNum = 0;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                Console.WriteLine($"Failed to collect required money for charity.");
                break;
            }

            int price = int.Parse(input);
            transactionNum++;

            if (transactionNum % 2 == 1) // cash 
            {
                if (price <= 100)
                {
                    Console.WriteLine($"Product sold!");
                    cashPay += price;
                    cashCount++;
                    collectedSum += price;

                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                }
            }

            else //card
            {
                if (price >= 10)
                {
                    Console.WriteLine($"Product sold!");
                    cardPay += price;
                    cardCount++;
                    collectedSum += price;
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                }


            }

            if (collectedSum >= expectedSum)
            {
                double ACSCash = cashPay / cashCount;
                double ACSCard = cardPay / cardCount;

                Console.WriteLine($"Average CS: {ACSCash:f2}");
                Console.WriteLine($"Average CC: {ACSCard:f2}");
                break;
            }
            
        }

        
    }
}

