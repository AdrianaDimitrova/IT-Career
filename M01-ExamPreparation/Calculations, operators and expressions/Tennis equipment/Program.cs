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
        double racket = double.Parse(Console.ReadLine());
        int racketsCount = int.Parse(Console.ReadLine());
        int shoes = int.Parse(Console.ReadLine());

        //Action
        double racketsPrice = racket * racketsCount;
        double shoesPrice = racket / 6;
        double allShoesPrice = shoes * shoesPrice;
        double equipmentPrice = (racketsPrice + allShoesPrice) * 0.2;

        double totalPrice = racketsPrice + allShoesPrice + equipmentPrice;

        double Djokovic = totalPrice / 8;
        double sponsors = totalPrice *7/8;

        //Output 
        Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(Djokovic)}");
        Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsors)}");

    }
}

