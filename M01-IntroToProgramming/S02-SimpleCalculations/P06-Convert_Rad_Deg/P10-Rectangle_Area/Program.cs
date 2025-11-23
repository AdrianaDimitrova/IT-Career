using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {   // т.А (x1;x2)
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        // т.B (y1;y2)
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        //Calculations
        double a = Math.Abs(y1 - y2);
        double b = Math.Abs(x1 - x2);
        double S = (a * b);
        double P = 2 * (a + b);
        // Output
        Console.WriteLine(S);
        Console.WriteLine(P);
    }
}

