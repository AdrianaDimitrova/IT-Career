using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        PrintLine();
        
    }
    public static void PrintLine()
    {
        Console.WriteLine("-----------------------------------------------");

    }
    public static void PrintSum(int a, int b)
    {
        Console.WriteLine($"Sum = {a+b}");
    }
}

