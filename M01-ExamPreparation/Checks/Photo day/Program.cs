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
        int time = int.Parse(Console.ReadLine());
        int scenes = int.Parse(Console.ReadLine());
        int duration = int.Parse(Console.ReadLine());

        //Action
        double preparation = time * 0.15;
        double shoothingTime = scenes * duration;
        double neededTime = preparation + shoothingTime;

        if (time > neededTime)
        {
            Console.WriteLine($"You managed to finish the movie on time! You have {Math.Abs(time - neededTime)} minutes left!");
        }
        else
        {
            Console.WriteLine($"Time is up! To complete the movie you need {Math.Abs(neededTime-time)} minutes.");
        }


    }
}

