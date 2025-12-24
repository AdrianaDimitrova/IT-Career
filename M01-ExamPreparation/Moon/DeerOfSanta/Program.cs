using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int absentDays = int.Parse(Console.ReadLine());
        int food = int.Parse(Console.ReadLine());
        double foodElen1 = double.Parse(Console.ReadLine());
        double foodElen2= double.Parse(Console.ReadLine());
        double foodElen3 = double.Parse(Console.ReadLine());
        double totalFood = (foodElen1 + foodElen2 + foodElen3)*absentDays;
        
        if (food >= totalFood)
        {
            Console.WriteLine($"Остават {Math.Floor(Math.Abs(food - totalFood))} kg");
        }
        else if (food < totalFood)
        {
            Console.WriteLine($"{Math.Ceiling(totalFood-food)} more kilos of food are needed.");
        }


        
    }
}

