using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        // Input
        double chickenMenu = 10.35;
        double fishMenu = 12.40;
        double vegMenu = 8.15;
        double delivery = 2.50;

        int countChickenMenu = int.Parse(Console.ReadLine());
        int countfishMenu = int.Parse(Console.ReadLine());
        int countvegMenu = int.Parse(Console.ReadLine());

        //Action
        double chickenPrice = chickenMenu * countChickenMenu;
        double fishPrice = fishMenu * countfishMenu;
        double vegPrice = vegMenu * countvegMenu;

        double MenuPrice = chickenPrice + fishPrice + vegPrice;
        double desertPrice = 0.20 * MenuPrice;

        //Output
        double Total = MenuPrice + desertPrice + delivery;
        Console.WriteLine($"Total: {Total}");





    }
}

