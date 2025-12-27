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
        double protectivenylonPrice = 1.50;
        double paintPrice = 14.50;
        double paintThinnerPrice = 5.00;

        int protectivenylon = int.Parse(Console.ReadLine());
        int paint = int.Parse(Console.ReadLine());
        int paintThinner = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());

        //Action
        double prtectNylonCost = (2 + protectivenylon) * protectivenylonPrice;
        double paintCost = (1.10 + paint) * paintPrice;
        double paintThinnerCost = paintThinner * paintThinnerPrice;
        double TotalPriceForMatherials = prtectNylonCost + paintCost + paintThinnerCost + 0.40;
        double workersSelary = (TotalPriceForMatherials * 0.3) * hours;

        double TotalPrice = TotalPriceForMatherials + workersSelary;
        //Output
        Console.WriteLine($"Total expenses: {TotalPrice:f2} lv.");


    }
}

