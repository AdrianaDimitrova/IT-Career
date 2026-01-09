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
        for (int i = 100; i <= 999; i++)
        {
            for (int j = 100; j <=999; j++)
            {
                for (int k = 100; k <= 999; k++)
                {
                    if (n % 5 == 0)
                    {
                        Console.WriteLine(n - i);
                    }
                    else if (n % 3 == 0)
                    {
                        Console.WriteLine(n - j);
                    }
                    else
                    {
                        Console.WriteLine(n+k);
                    }

                }
            }
        }

    }
}

