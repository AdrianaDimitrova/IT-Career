using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        double points = double.Parse(Console.ReadLine());
        double bonus = 0;

        if (points > 100 && points <= 1000)  {bonus = 0.2 * points;}
        else if (points > 1000)  { bonus = 0.1 * points; }
        else{ bonus = 5;}

        if (points % 2 == 0)  { bonus++; }
        else if (points % 5 == 0)  { bonus += 2; }

        Console.WriteLine(bonus);
        Console.WriteLine(bonus+points);
    }
}

