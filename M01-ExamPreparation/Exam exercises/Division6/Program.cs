using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int d2 = 0;
        int d3 = 0;
        int d5 = 0;

        int count = 0;

        for (int i = 0; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                d2++;
            }

            if (num % 3 == 0)
            {
                d3++;
            }

            if (num % 5 == 0)
            {
                d5++;
            }
        }
        Console.WriteLine($"{d2}");
        Console.WriteLine($"{d3}");
        Console.WriteLine($"{d5}");

    }
}

