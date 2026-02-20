
public class Program
{
    public static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine()!
            .Split(" ")
            .Select(x => int.Parse(string.Join("", x.Reverse())))
            .ToList();

        Console.WriteLine(nums.Sum());
         


    }
}

