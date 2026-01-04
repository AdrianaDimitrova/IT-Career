using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());


        double desksLenght = 1.2;
        double deskWide = 0.7;

        double deskW = h - 1;

        int rows = (int) (w / desksLenght);
        int columns = (int)(deskW / deskWide);

        int desks = rows * columns - 3;
        Console.WriteLine(desks);
    }
}

