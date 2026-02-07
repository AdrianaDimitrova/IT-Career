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
        int degustators = int.Parse(Console.ReadLine());

        int Masterpiece = 0;
        int Good = 0;
        int Ok = 0;
        int NeedsImprovement = 0;

        double sumGrades = 0;
        //Action
        for (int i = 1; i <=degustators; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            sumGrades += grade;

            if (grade >= 8.00)
            {
                Masterpiece++;
            }
            else if (grade >= 6.00 && grade <= 7.99)
            {
                Good++;
            }
            else if (grade >= 4.00 && grade <= 5.99)
            {
                Ok++;
            }
            else if (grade < 4)
            {
                NeedsImprovement++;
            }
        }

        Console.WriteLine($"Masterpiece: {(Masterpiece*100.0)/degustators:f2}%");
        Console.WriteLine($"Good: {Good*100.0/degustators:f2}%");
        Console.WriteLine($"Ok: {(Ok * 100.0) /degustators:f2}%");
        Console.WriteLine($"Needs improvement: {(NeedsImprovement * 100.0) /degustators:f2}%");
        Console.WriteLine($"Average: {sumGrades/degustators:f2}");

    }
}

