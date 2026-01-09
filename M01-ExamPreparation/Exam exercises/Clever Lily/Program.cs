using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        double washerPrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int toysCount = 0;
        double savedMoney = 0;
        double giftMoney = 0;
        int stolenMoney = 0;


        for (int birthday = 1; birthday <= age; birthday++)
        {
            if (birthday % 2 == 0)
            {
                giftMoney += 10;
                savedMoney += giftMoney;
                stolenMoney++;
            }
            else
            {
                toysCount++;
            }

        }
        savedMoney += toysCount * toyPrice;
        savedMoney -= stolenMoney;
        if (savedMoney >= washerPrice)
        {
            Console.WriteLine($"Yes! {(savedMoney - washerPrice):F2}");
        }
        else
        {
            Console.WriteLine($"No! {(washerPrice - savedMoney):F2}");
        }

    }
}

