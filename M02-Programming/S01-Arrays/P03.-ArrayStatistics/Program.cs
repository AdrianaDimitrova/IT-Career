using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        // V1

        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (nums[i] < min)
            {
                min = nums[i];
            }
            if (nums[i] > max)
            {
                max = nums[i];
            }

            double average = sum / (double)nums.Length;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }

        // V2

        int[] numbers = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Average = {numbers.Average()}");
    }

}


