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
        double flourPrice = double.Parse(Console.ReadLine());
        double flourKg = double.Parse(Console.ReadLine());
        double sugarKg = double.Parse(Console.ReadLine());
        int eggs = int.Parse(Console.ReadLine());
        int yeast = int.Parse(Console.ReadLine());

        //Action
        double sugarPrice = flourPrice * 0.75;
        double eggsPrice = flourPrice * 1.1;
        double yeastPrice = sugarPrice * 0.2;

        double flourSum = flourPrice * flourKg;
        double sugarSum = sugarPrice * sugarKg;
        double eggsSum = eggsPrice * eggs;
        double yeastSum = yeastPrice * yeast;

        double totalSum = sugarSum + eggsSum + yeastSum +flourSum ;

        //Output
        Console.WriteLine($"{totalSum:f2}");

    }
}

