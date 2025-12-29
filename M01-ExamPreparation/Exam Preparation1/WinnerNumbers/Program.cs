using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinnerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i < 9; i++)
            {
                for (int j =1; j < 9; j++)
                {
                    for (int k = 1; k < 9; k++)
                    {
                        for (int l = 1; l < 9; l++)
                        {
                            if (i + j == N && k % 2 == 0 && (l == 3 || l == 6))
                            {
                                Console.WriteLine($"{i}{j}{k}{l}");
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Count of winner numbers: {count}");
           
        }
    }
}
