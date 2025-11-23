using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    private const double InchToCentimeters = 2.54;
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter inch: ");
        double inch = double.Parse(Console.ReadLine());
        double cm = inch * InchToCentimeters;
        Console.WriteLine($"Cantimeters: {cm}");
    }
}

