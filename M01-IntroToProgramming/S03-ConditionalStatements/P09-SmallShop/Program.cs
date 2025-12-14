using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;


using System;
public class Program
{
    public static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        double price = 0.0;
        double totalPrice = count * price;

        switch (product)
        {
            case "coffee":
                if (town == "Sofia")
                {
                    price = 0.50;
                }
                else if (town == "Plovdiv")
                {
                    price = 0.40;
                }
                else if (town == "Varna")
                {
                    price = 0.45;
                }
                break;

            case "water":
                if (town == "Sofia")
                {
                    price = 0.80;
                }
                else if (town == "Plovdiv")
                {
                    price = 0.70;
                }
                else if (town == "Varna")
                {
                    price = 0.75;
                }
                break;


            case "beer":
                if (town == "Sofia")
                {
                    price = 1.20;
                }
                else if (town == "Plovdiv")
                {
                    price = 1.15;
                }
                else if (town == "Varna")
                {
                    price = 1.10;
                }
                break;


            case "sweets":
                if (town == "Sofia")
                {
                    price = 1.45;
                }
                else if (town == "Plovdiv")
                {
                    price = 1.30;
                }
                else if (town == "Varna")
                {
                    price = 1.35;
                }
                break;


            case "peanuts":
                if (town == "Sofia")
                {
                    price = 1.60;
                }
                else if (town == "Plovdiv")
                {
                    price = 1.50;
                }
                else if (town == "Varna")
                {
                    price = 1.55;
                }
                break;

        }
        Console.WriteLine(totalPrice);





    }
}

