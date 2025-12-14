using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string word = Console.ReadLine();
            if (word == "END")
            {
                break;
            }
            Console.WriteLine(IsPalindrome(word));
        }
        Console.WriteLine(IsPalindrome(Console.ReadLine()));

    }
    public static bool IsPalindrome(string input)
    {
        for (int i = 0; i < input.Length/2; i++)
        {
            char first = input[i];
            char last = input[input.Length - 1 - i];
            if (first != last)
            {
                return false;
            }
            return true;
        }
    }
}

