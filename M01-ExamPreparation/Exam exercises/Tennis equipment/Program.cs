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
        int racetsCount = int.Parse(Console.ReadLine());
        int trainersCount = int.Parse(Console.ReadLine());

        //Action
        double racketsPrice = racetsCount * racket;
        double trainersPrice = racket / 6;
        double alltrainersPrice = trainersCount * trainersPrice;

        double equipmentPrice = (racketsPrice + alltrainersPrice) * 0.2;

        double totalPrice = racketsPrice + alltrainersPrice + equipmentPrice;

        double DjokovicPrice = totalPrice / 8;
        double sponsorsPrice = totalPrice*7/ 8;

        Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(DjokovicPrice)}");
        Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorsPrice)}");
    }
}

