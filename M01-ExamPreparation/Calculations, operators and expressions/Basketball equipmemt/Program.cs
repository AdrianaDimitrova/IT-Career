using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        //Input
        int fee = int.Parse(Console.ReadLine());

        double shoes = fee * 0.6;
        double sweatsuit = shoes * 0.8;
        double ball = sweatsuit / 4;
        double accessories = ball / 5;

        //Action
        double total = fee + shoes + sweatsuit + ball + accessories;

        //Output 
        Console.WriteLine($"{total:f2}");
        




    }
}

