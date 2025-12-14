using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int n = 2;
        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <=9; j++)
            {
                for (int k = 0; k <= 9; k++)
                {
                    for (int d = 0; d <= 9 ; d++)
                    {
                        for (int e = 0; e <=9; e++)
                        {
                            for (int m = 0; m <= 9; m++)
                            {
                                if (i * j * k * d * e * m == n)
                                    Console.WriteLine($"{i}{j}{k}{d}{e}{m}");

                            }

                        }

                    }

                }

            }
            

        }
    }
}

