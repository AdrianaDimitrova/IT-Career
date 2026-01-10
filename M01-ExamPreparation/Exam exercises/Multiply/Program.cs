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

        int a = n % 10;
        int b = (n / 10) % 10;
        int c = n / 100;

        for (int i = 1; i <=a; i++)
        {
            for (int j = 1; j <=b; j++)
            {
                for (int k = 1; k <=c; k++)
                {
                    int number = i * j * k;
                    Console.WriteLine($"{i} * {j} * {k} = {number}");
                }
            }
        }
    }
}

