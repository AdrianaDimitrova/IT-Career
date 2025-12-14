using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            // Action
            for (int i = 1; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                }
                if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                 if (number >= 800)
                {
                    p5++;
                }
            }

            //Output
            Console.WriteLine($"P1 = {p1/(double)n*100:f2}%");
            Console.WriteLine($"P2 = {p2/(double)n*100:f2}%");
            Console.WriteLine($"P3 = {p3/(double)n*100:f2}%");
            Console.WriteLine($"P4 = {p4 / (double)n *100:f2}%");
            Console.WriteLine($"P5 ={p5 / (double)n *100:f2}%");
        }
    }
}
