using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            double n = double.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine($"Result: {n*2:f2}");
                
            }

            else
            {
                Console.WriteLine($"Negative number!");
                break;
                
            }
        }
    }
}

