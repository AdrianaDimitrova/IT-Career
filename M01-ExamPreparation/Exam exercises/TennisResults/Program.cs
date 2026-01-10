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

        int wonCount = 0;

        string result = Console.ReadLine();
        if (result[0] > result[2])
        {
            wonCount++;
        }

        result = Console.ReadLine();
        if (result[0] > result[2])
        {
            wonCount++;
        }

        result = Console.ReadLine();
        if (result[0] > result[2])
        {
            wonCount++;
        }

        Console.WriteLine($"Grigor won {wonCount} games.");
        Console.WriteLine($"Grigor lost {3-wonCount} games.");




    }
}

