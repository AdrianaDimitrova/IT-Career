using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());

        int arrivingHour = int.Parse(Console.ReadLine());
        int arrivingMinutes = int.Parse(Console.ReadLine());

        int examTotalMinutes = examHour * 60 + examMinutes;
        int arriningTotalMinutes = arrivingHour * 60 + arrivingMinutes;

        int diff = arriningTotalMinutes - examTotalMinutes;

        if (diff > 0)
        {
            Console.WriteLine("Late");
        }

        else if (diff >= -30)
        {
            Console.WriteLine("On time");
        }

        else
        {
            Console.WriteLine("Early");
        }

        if (diff != 0)
        {
            double hours = Math.Abs(diff) / 60;
            double minutes = Math.Abs(diff) % 60;

            if (diff > 0)
            {
                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }

            else
            {
                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }



        }








    }
}

