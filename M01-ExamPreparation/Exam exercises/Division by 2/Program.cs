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

        double p1Count = 0;
        double p2Count = 0;
        double p3Count = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                p1Count++;
            }
            else if (num % 3 == 0)
            {
                p2Count++;
            }
            else if (num % 4 == 0)
            {
                p3Count++;
            }

        }
        double p1Percent = (p1Count / n) * 100;
        double p2Percent = (p2Count / n) * 100;
        double p3Percent = (p3Count / n) * 100;

        Console.WriteLine($"{p1Percent:f2}%");
        Console.WriteLine($"{p2Percent:f2}%");
        Console.WriteLine($"{p3Percent:f2}%");
    }
}

