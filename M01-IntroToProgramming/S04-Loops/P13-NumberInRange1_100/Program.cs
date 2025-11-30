using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number in range: ");
        int n = int.Parse(Console.ReadLine());
        while (n < 1 || n > 100)
        {
            Console.WriteLine("Invalid number");

            Console.WriteLine("Enter a number in range: ");
             n = int.Parse(Console.ReadLine());

        }
        Console.WriteLine($"The number is: {n} ");


    }
}

