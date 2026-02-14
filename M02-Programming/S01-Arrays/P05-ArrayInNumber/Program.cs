
public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        while (nums.Length > 1)
        {
            int[] consensed = new int[nums.Length - 1];

            for (int i = 0; i < consensed.Length; i++)
            {
                consensed[i] = nums[i] + nums[i + 1];
            }
            nums = consensed;


            Console.WriteLine(nums[0]);
        }
    }
}

