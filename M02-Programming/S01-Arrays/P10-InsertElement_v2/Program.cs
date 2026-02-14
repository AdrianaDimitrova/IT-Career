using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int n = int.Parse(Console.ReadLine());

        int index = nums.Count(x => x < n);

        int[] newNums = new int[nums.Length + 1];
        Array.Copy(nums, 0, newNums, 0,index);
        newNums[index] = n;

        Array.Copy(nums, index, newNums, index + 1, nums.Length - index);

        Console.WriteLine($"Nums: {string.Join(" , ", nums)}");
        Console.WriteLine($"New nums: {string.Join(" , ", newNums)}");
    }
}

