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
        int games = int.Parse(Console.ReadLine());
        int points = int.Parse(Console.ReadLine());

        int tournamentsPoints = 0;
        int winns = 0;
  
        //Action
        for (int i = 0; i < games; i++)
        {
            string typeGame = Console.ReadLine();

            switch (typeGame)
            {
                case "W":
                    tournamentsPoints += 2000;
                    winns++;
                    break;

                case "F":
                    tournamentsPoints += 1200;
                    break;

                case "SF":
                    tournamentsPoints += 720;
                    break;
            }
        }
        int total = points + tournamentsPoints;
        double averagePoints = tournamentsPoints / games;
        double procentsWinns = winns/ (double)games * 100.0;

        Console.WriteLine($"Final points: {total}");
        Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
        Console.WriteLine($"{procentsWinns:f2}%");
    }
}
