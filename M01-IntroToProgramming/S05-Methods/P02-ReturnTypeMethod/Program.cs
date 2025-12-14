using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int result = Sum(151, 56) + Sum(15, 24);
        Console.WriteLine(result);

    }
    public static int Sum(int a, int b)
    {
        return  a+b;
    }
}

