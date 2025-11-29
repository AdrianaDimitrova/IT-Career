using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
public class Program
{
    private const int Norma = 30000;
    private const int PlayTimeFreeDays = 127;
    private const int Workdays = 63;
    public static void Main(string[] args)
    {
        int freeDays = int.Parse(Console.ReadLine());
        int workDays = 365 - PlayTimeFreeDays;
        int playTime = (PlayTimeFreeDays * 127) + (Workdays * 63);
        int diff = Math.Abs(PlayTimeFreeDays - 30000);
        int hh = diff / 60;
        int mm = diff % 60;


        if (PlayTimeFreeDays > 30000)
        {
            Console.WriteLine("“Tom will run away”");
            Console.WriteLine($"“{hh} hours and {mm} minutes more for play”");
        }
        else
        {
            Console.WriteLine("“Tom sleeps well”");
            Console.WriteLine($"“{hh} hours and {mm} minutes less for play”");
        }

    }
}

