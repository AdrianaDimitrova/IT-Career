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
        int sweetbread = int.Parse(Console.ReadLine());
        int eggs = int.Parse(Console.ReadLine());
        int biscuits= int.Parse(Console.ReadLine());

        double sweetbreadfirstprice = 3.20;
        double eggsPricefirstprice = 4.35;
        int eggsCount = 12;
        double biscuitsPricefirstprice = 5.40;
        double paintfirstprice = 0.15;

        //Action
        double currentPriceSweetbread = sweetbread * sweetbreadfirstprice;
        double currentPriceEggs = eggs * eggsPricefirstprice;
        double currentpriceBiscuits = biscuits * biscuitsPricefirstprice;
        double currentPaintPrice = eggs * eggsCount * paintfirstprice;

        double Total = currentPriceSweetbread + currentPriceEggs + currentpriceBiscuits+currentPaintPrice;

        //Output 
        Console.WriteLine($"{Total:f2}");
    }
}

