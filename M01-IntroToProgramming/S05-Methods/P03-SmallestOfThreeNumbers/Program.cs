using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(SmallestOfThreeNumbers(a,b,c));

    }
    public static int SmallestOfThreeNumbers(int a, int b, int c)
    {
        if (a < b && a < c)
        {
            return a;
        }
        else if (b < a && b < c)
        {
            return b;
        }
        else
        {
            return c;
        }
        // return Math.Max(Math.Max(a,b),c);
    }
 
        

}
