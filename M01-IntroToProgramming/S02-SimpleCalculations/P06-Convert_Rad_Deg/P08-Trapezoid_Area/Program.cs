using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
class Program
{
    private static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double S = (a + b) * h / 2;
        Console.WriteLine($"Trapezoid area is: {S}");

    }
}

