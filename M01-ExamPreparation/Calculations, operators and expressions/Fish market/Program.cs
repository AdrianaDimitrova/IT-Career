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
        double skumriq = double.Parse(Console.ReadLine());
        double tsatsa = double.Parse(Console.ReadLine());
        double palamud = double.Parse(Console.ReadLine());
        double safrid = double.Parse(Console.ReadLine());
        int midi = int.Parse(Console.ReadLine());

        //Action
        double palamudPrice = 1.6 * skumriq;
        double safridPrice = 1.8 * tsatsa;

        double palamudSum = palamud * palamudPrice;
        double safridSum = safrid * safridPrice;
        double midiSum = midi *7.50 ;

        double TotalSum = palamudSum + safridSum + midiSum;

        //Output
        Console.WriteLine($"{TotalSum:f2}");

    }
}

