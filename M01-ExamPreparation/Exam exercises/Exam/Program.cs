using System;



public class Program
{
    public static void Main(string[] args)
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinutes = int.Parse(Console.ReadLine());

        int examTotalMinutes = examHour * 60 + examMinutes;
        int arrivalTotalMinutes = arrivalHour * 60 + arrivalMinutes;

        int diff = arrivalTotalMinutes - examTotalMinutes;

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
            Console.WriteLine($"Early");
        }

        if (diff != 0)
        {
            int hours = Math.Abs(diff) / 60;
            int minutes = Math.Abs(diff) % 60;

            if (diff > 0)
            {
                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
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
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{ minutes} minutes before the start ");
                }
            }
        }
        

    }
}

