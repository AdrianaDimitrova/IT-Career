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

        //Action
        double decoration = hall * 0.25;
        double sound = decoration + 50;
        double security = (hall + sound) * 0.15;
        double cleaning = hall * 0.10;

        double total = hall + decoration + sound + security + cleaning;
        Console.WriteLine($"{total:f2}");
    }
}

