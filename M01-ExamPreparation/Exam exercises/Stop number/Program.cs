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
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());

        //Action
        for (int i = M; i >= N; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                if (i == S)
                {
                    break;
                }
                Console.Write(i + " ");
            }

            
        }
    }
}

