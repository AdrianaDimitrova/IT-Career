using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());

        double VIPTicketPrice = 499.99;
        double Normal = 249.99;

        double transpoirtPercent = 0;
        

        if (people >= 1 && people <= 4)
        {
            transpoirtPercent = 0.75 ;
        }
        else if (people >= 5 && people <= 9)
        {
            transpoirtPercent = 0.60 ;
        }
        else if (people >= 10 && people <= 24)
        {
            transpoirtPercent = 0.50;
        }
        else if (people >= 25 && people <= 49)
        {
            transpoirtPercent = 0.40 ;
        }
        else if (people >= 50)
        {
            transpoirtPercent = 0.25;
        }

        double transportCost = budget * transpoirtPercent;
        double leftMoney = budget - transportCost;

        double ticketPrice = 0;

        if (type == "VIP")
        {

              ticketPrice = VIPTicketPrice * people;
        }
        else if (type == "Normal")
        {
             ticketPrice = Normal * people ;
        }

        if (leftMoney >= ticketPrice)
        {
            Console.WriteLine($"Yes! You have {leftMoney-ticketPrice:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {ticketPrice-leftMoney:f2} leva.");
        }

    }
}

