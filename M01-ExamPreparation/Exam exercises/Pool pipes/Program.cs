using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int volume = int.Parse(Console.ReadLine());
        int P1 = int.Parse(Console.ReadLine());
        int P2 = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double P1Work = hours * P1;
        double P2Work = hours * P2;
        double totalWork = P1Work + P2Work;

        if (totalWork <= volume)
        {
            Console.WriteLine($"The pool is {(int)((totalWork / volume)*100)}% full. Pipe 1: {(int)((P1Work/totalWork)*100)}%. Pipe 2: {(int)((P2Work /totalWork) * 100)}%");

        }
        else
        {
            Console.WriteLine($"For {hours} hours the pool overflows with {totalWork-volume:f1} liters.");
        }





    }
}

