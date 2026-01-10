using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


public class Program
{
    public static void Main(string[] args)
    {
        //Input
        int housePrice = int.Parse(Console.ReadLine());

        //Action
        double foodPrice = housePrice * 0.4;
        double drinksPrice = foodPrice / 3;
        double transportPrice = 0.45 * (foodPrice + drinksPrice);

        double totalPrice = housePrice + foodPrice + drinksPrice + transportPrice;

        Console.WriteLine($"{totalPrice:f2}");
    }
}

