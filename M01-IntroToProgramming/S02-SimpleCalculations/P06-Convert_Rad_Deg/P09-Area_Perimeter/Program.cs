using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        double S = Math.PI * r * r;
        double P = 2 * Math.PI * r;
        Console.WriteLine($"The area is: {S:f2}");
        Console.WriteLine($"The perimeter is: {P:f2}");

    }
}

