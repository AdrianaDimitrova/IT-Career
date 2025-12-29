using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        //Inpuut
        double budget = double.Parse(Console.ReadLine());
        int statists = int.Parse(Console.ReadLine());
        double clothesPrice = double.Parse(Console.ReadLine());

        //Action
        double decorPrice = budget * 0.1;
        double clothesSum = statists * clothesPrice;
        if (statists > 150)
        {
            clothesSum *= 0.90;
        }

        double TotalSum = decorPrice + clothesSum;

        if (TotalSum> budget)
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {Math.Abs(TotalSum- budget):f2} leva more.");
        }
        else if (TotalSum<= budget)
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {Math.Abs(budget-TotalSum):f2} leva left.");
        }
    }
}

