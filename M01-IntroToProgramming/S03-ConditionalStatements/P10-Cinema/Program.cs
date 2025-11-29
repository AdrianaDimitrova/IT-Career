using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int seats = rows * cols;

        double price = 0.00;

        switch (type)
        {
            case "Premiere":
                price = 12.00;
                break;

            case "Normal":
                price = 7.5;
                break;

            case "Discount":
                price = 5.00;
                break;
        }

        double totalPrice = price * seats;
        Console.WriteLine($"{totalPrice:f2} lv.");



    }
}

