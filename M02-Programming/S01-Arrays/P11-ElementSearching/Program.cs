public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == n)
            {
                Console.WriteLine("Yes");
                return;
            }
        }
        Console.WriteLine("No");
    }
}

