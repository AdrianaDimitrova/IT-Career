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
        int n = int.Parse(Console.ReadLine());

        //Action
        int w = 5 * n;
        int h = 3 * n + 2;

        Console.WriteLine(new string('.', n) + new string('*', w - 2 * n) + new string('.', n));

        int outerDots = n - 1;
        int innerDots = w - 2 * (outerDots + 1);

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(
               new string('.', outerDots) +
               "*" +
               new string('.', innerDots) +
               "*" +
               new string('.', outerDots));

            outerDots--;
            innerDots += 2;
        }

        Console.WriteLine(new string('*', w));

        // 4. Lower shrinking part
        outerDots = 1;
        innerDots = w - 4;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(
                new string('.', outerDots) +
                "*" +
                new string('.', innerDots) +
                "*" +
                new string('.', outerDots)
            );

            outerDots++;
            innerDots -= 2;
        }

        // 5. Bottom rows
        int bottomRows = n + 1;
        int dots = n;

        for (int i = 0; i < bottomRows; i++)
        {
            Console.WriteLine(
                new string('.', dots) +
                new string('*', w - 2 * dots) +
                new string('.', dots)
            );

            dots++;
        }
    }
}

