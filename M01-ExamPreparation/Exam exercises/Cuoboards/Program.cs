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
        int n = int.Parse(Console.ReadLine());

        //Action
        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                for (int k = 0; k <= 9; k++)
                {
                    for (int l = 0; l <= 9; l++)
                    {
                        if (i + l == n && j % 2 == 0 && (k == 3 || k == 8))
                        {
                            Console.Write($"{i}{j}{k}{l} ");
                        }
                    }
                }
            }
        }
        Console.WriteLine();

    }
}

