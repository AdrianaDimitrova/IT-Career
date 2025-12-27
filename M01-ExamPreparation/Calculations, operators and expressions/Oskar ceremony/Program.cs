using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        //Input
        int hall = int.Parse(Console.ReadLine());

        double statuePrice = hall * 0.7;
        double catering = statuePrice * 0.85;
        double voicing = catering /2;

        //Action 
        double Total = hall + statuePrice + catering + voicing;

        //Output
        Console.WriteLine($"{Total:f2}");













    }
}

