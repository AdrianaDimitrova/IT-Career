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
        double fooddeef1 = double.Parse(Console.ReadLine());
        double fooddeef2 = double.Parse(Console.ReadLine());
        double fooddeef3 = double.Parse(Console.ReadLine());

        double deef1 = absentDays * fooddeef1;
        double deef2 = absentDays * fooddeef2;
        double deef3 = absentDays * fooddeef3;

        double totalFood = deef1 + deef2 + deef3;
        if (food > totalFood)
        {
            Console.WriteLine($"{food - totalFood:f2} kilos of food left.");
        }
        else
        {
            Console.WriteLine($"{totalFood-food:f2} more kilos of food are needed.");
        }
             
    }
}

