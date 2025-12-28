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
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        //Action
        double frontWall = x * x;
        double backWall = x * x;
        double door = 1.2 * 2;
        double frontAndbackWallsTotalArea= 2*frontWall  - door;

        double sideWall1 = x * y;
        double sideWall2 = x * y;
        double windows = 2*(1.5 *1.5);
        double sideWallsTotalArea = 2 * sideWall1 - windows;

        double TotalWallssAreas = frontAndbackWallsTotalArea + sideWallsTotalArea;

        double greenPaint = TotalWallssAreas / 3.4;
        

        double roofrectangles = 2 * (x * y);
        double rooftriangles = 2 * ((x * h) / 2);
        double roofTotalArea = roofrectangles + rooftriangles;

        double redPaint = roofTotalArea / 4.3;

        //Output
        Console.WriteLine($"Зелена боя {greenPaint:f2}литра");
        Console.WriteLine($"Червена боя {redPaint:f2}литра");
    }
}

