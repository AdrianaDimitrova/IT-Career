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
        int vehicle = int.Parse(Console.ReadLine());

        int carsCount = 0;
        int busesCount = 0;
        int trucksCount = 0;
        
        for (int i = 0; i < vehicle; i++)
        {
            string veh = Console.ReadLine();
            if (veh == "car")
            {
                carsCount++;
            }
            else if (veh == "bus")
            {
                busesCount++;
            }
            else if (veh == "truck")
            {
                trucksCount++;
            }
        }
        Console.WriteLine($"Cars: {carsCount}");
        Console.WriteLine($"Buses: {busesCount}");
        Console.WriteLine($"Trucks: {trucksCount}");
    }
}
