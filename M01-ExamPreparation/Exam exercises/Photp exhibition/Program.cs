using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Program
{
    public static void Main(string[] args)
    {   //Input
        int hall = int.Parse(Console.ReadLine());

        //Action
        double equipment = hall * 0.4;
        double adPrice = equipment / 5;
        double stuff = (equipment + adPrice) * 0.6;
        double total = hall + equipment + adPrice + stuff;
        Console.WriteLine($"{total:f2}");


    }
}

