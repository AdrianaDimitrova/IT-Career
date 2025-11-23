using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
public class Program
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            for (int a =0; i < N; a++)
            {
                Console.Write("*");
                break;
            }

            for (int a = 0; i < N; a++)
            {
                Console.Write("*");
                break;
            }
            Console.WriteLine();
        }

    }
}

