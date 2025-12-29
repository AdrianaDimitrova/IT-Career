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
        int days = int.Parse(Console.ReadLine());
        int food = int.Parse(Console.ReadLine());
        double foodDog = double.Parse(Console.ReadLine());
        double foodCat = double.Parse(Console.ReadLine());
        double foodTurtle = double.Parse(Console.ReadLine());

        //Action
        double neededFoodDog = days * foodDog;
        double neededFoodCat = days * foodCat;
        double neededFoodTurtle = days * foodTurtle;

        double totalFood = neededFoodCat + neededFoodDog + neededFoodTurtle;

        if (totalFood < food)
        {
            Console.WriteLine($"{Math.Floor(food - totalFood)} kilos of food left.");
        }
        else
        {
            Console.WriteLine($"{Math.Ceiling(totalFood-food)} more kilos of food are needed.");
        }
    }
}

