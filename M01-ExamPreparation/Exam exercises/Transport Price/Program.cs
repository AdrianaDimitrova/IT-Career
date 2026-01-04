using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        int km = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();

        double price=0;

        if (km >= 100)
        {
            price = km * 0.06;
        }

        else if(km>=20)
        {
            price = km * 0.09;
        }

        else
        {
            if (dayTime == "day")
            {
                price = km * 0.79 + 0.70;

            }
            else if (dayTime == "night")
            {
                price = km * 0.90 + 0.70;
            }

        }
        Console.WriteLine(price);
    }
}

