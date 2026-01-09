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
        double money = double.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        //Action
        int age = 18;

        for (int currentYear = 1800; currentYear <= year; currentYear++)
        {
            if (currentYear % 2 == 0)
            {
                money -= 12000;
            }
            else
            {
                money -= 12000 + (age * 50);
            }
            age++;
        }
        if (money >=0)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
        }
        else
        {
            Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
        }


    }
}

