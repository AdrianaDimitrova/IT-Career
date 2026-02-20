using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine()!
            .Split()
            .Select(int.Parse)
            .OrderBy(x=>x)
            .ToList();

        List<int> result = nums.Where(x=>x == nums.Min() || x==nums.Max()).ToList();

        Console.WriteLine(string.Join(" ", result));
    }
        
}


