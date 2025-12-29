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
        int hours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        //Action
        double workingHours = 0.9 * days *8;
        double emergwork = workers * (2 * days);
        double totalHours = Math.Floor(workingHours + emergwork);

        //Output
        if (hours < totalHours)
        {
            Console.WriteLine($"Yes!{Math.Abs(hours-totalHours)} hours left.");
        }
        else
        {
            Console.WriteLine($"Not enough time!{Math.Abs(totalHours-hours)} hours needed.");
        }


    }
}

