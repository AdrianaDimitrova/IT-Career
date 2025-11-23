using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        double USD = double.Parse(Console.ReadLine());
        double BGN = USD* 1.79549;
        Console.WriteLine($"{BGN:f2} BGN");


    }
}

