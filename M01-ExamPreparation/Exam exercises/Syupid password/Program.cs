using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                for (int k = 0; k <= l; k++)
                {
                    for (int m = 0; m <= l; m++)
                    {
                        for (int o = 0; o <= n; o++)
                            if (o > i && o > j)
                            {
                                char firstLetter = (char)('a' + k-1);
                                char secondLetter = (char)('a' + m-1);

                                Console.Write($"{i}{j}{firstLetter}{secondLetter}{o}");
                            }
                        


                    }

                }

            }
        }

    }
}

