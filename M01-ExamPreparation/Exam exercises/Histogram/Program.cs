using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;



        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 200)
            {
                p1++;
                
            }
            else if (num >= 200 && num <= 399)
            {
                p2++;
                
            }
            else if (num >= 400 && num <= 599)
            {
                p3++;
                
            }
            else if (num >= 600 && num <= 799)
            {
                p4++;
                
            }
            else if (num >= 800)
            {
                p5++;
                
            }

           
        }
        double p1Count = p1 / n * 100;
        double p2Count = p2 / n * 100;
        double p3Count = p3 / n * 100;
        double p4Count = p4 / n * 100;
        double p5Count = p5 / n * 100; 

        Console.WriteLine($"{p1Count:f2}%");
        Console.WriteLine($"{p2Count:f2}%");
        Console.WriteLine($"{p3Count:f2}%");
        Console.WriteLine($"{p4Count:f2}%");
        Console.WriteLine($"{p5Count:f2}%");


    }
}

