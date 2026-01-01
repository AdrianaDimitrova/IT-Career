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
        int restDays = int.Parse(Console.ReadLine());
        int playTimeTom = 30000;

        //Action 
        int workingDays = 365 - restDays;
        int playTime = workingDays * 63 + restDays * 127;

        int diference = Math.Abs(playTime - playTimeTom);
        int hours = diference / 60;
        int minutes = diference - (hours * 60);

        if (playTimeTom < playTime)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{hours} hours and {minutes} minutes less for play");

        }
        

    }
}

