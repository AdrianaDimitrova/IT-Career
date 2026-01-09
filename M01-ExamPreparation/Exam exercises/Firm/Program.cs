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
        int neededHours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int workersCount = int.Parse(Console.ReadLine());

        //Action
        double workingDays = 0.9 * days;
        double workingHours = workingDays*8;

        double overTimeWorking = workersCount*days*2;
        int totalHours = (int)Math.Floor(workingHours + overTimeWorking);

        if (totalHours >= neededHours)
        {
            Console.WriteLine($"Yes!{totalHours-neededHours} hours left.");
        }
        else if (totalHours <= neededHours)
        {
            Console.WriteLine($"Not enough time!{neededHours-totalHours} hours needed.");
        }
    }
}

