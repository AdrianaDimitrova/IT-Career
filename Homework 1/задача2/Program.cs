using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Въведи число");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i < 10; i++)
        {

            if (num > 0 && num % 2 == 0 || num % 7 == 0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Числата не отговарят на едно или повече условия.");
            }

        }
    }
}

