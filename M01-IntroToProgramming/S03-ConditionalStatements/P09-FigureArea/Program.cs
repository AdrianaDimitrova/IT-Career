using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        string type = Console.ReadLine();
        double result = 0;

        switch (type)
        {
            case "square":
                double a = double.Parse(Console.ReadLine());
                result = a * a;
                break;

            case "triangle":
                double b = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                result = (b * h) / 2;
                break;

            case "circle":
                double r = double.Parse(Console.ReadLine());
                result = Math.PI * r * r;
                break;

            case "rectangle":
                double s = double.Parse(Console.ReadLine());
                double m = double.Parse(Console.ReadLine());

                result = s * m;
                break;
        }
        Console.WriteLine($"{Math.Round(result, 3)}");
    }
}

