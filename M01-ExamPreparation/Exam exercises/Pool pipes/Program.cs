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
        int V = int.Parse(Console.ReadLine());
        int P1 = int.Parse(Console.ReadLine());
        int P2 = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        //Action
        double P1work = P1 * hours;
        double P2work = P2 * hours;
        double totalpipeswork = (P1work + P2work);

        if (totalpipeswork < V)
        {
            double firstPipe = (P1work / totalpipeswork)*100;
            double secondPipe = (P2work / totalpipeswork)*100;
            Console.WriteLine($"The pool is {totalpipeswork/10}% full. Pipe 1: {Math.Floor(firstPipe)}%. Pipe 2: {Math.Floor(secondPipe)}%");
        }
        else if (totalpipeswork>V)
        {
            Console.WriteLine($"For {hours} hours the pool overflows with {Math.Abs(V-totalpipeswork):f1} liters.");
        }



    }
}

