using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers: ");
        int[] nums = Console.ReadLine() // масив      // "5 10 9 7 8 "
            .Split(' ')// разделяне на елементите    //  ["5" "10" "9" "7" "8"
            .Select(x => int.Parse(x)) // за всеки елемент изпълни операцията    // [5 10 9 7 8 ]
            .ToArray(); // превръщане в масив

        Console.WriteLine($"Lenght : {nums.Length}");
        Console.WriteLine(string.Join(",", nums));

    }
}


