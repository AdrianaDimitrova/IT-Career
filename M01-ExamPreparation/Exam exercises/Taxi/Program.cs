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
        double km = double.Parse(Console.ReadLine());
        int hour = int.Parse(Console.ReadLine());

        double price = 0;
        //Action
        if (hour >= 6 && hour < 22)
        {
            price = 1 + (km * 0.60);
        }
        else 
        {
            price = 1 + (km * 0.75);
        }
        Console.WriteLine($"{price:f2}");
        
    }
}

