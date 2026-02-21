using System.Diagnostics.CodeAnalysis;

public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine()!
            .Split(" ")
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            string[] args=Console.ReadLine()!
                .Split(" ")
                .ToArray();

            string comd = args[0];

            switch (comd)
            {
                case nameof(Add):
                    Add(nums, args);
                    break;

                case nameof (AddMany):
                    AddMany(nums, args);
                    break;

                case nameof(Contains):
                    Contains(nums, args);
                    break;

                case nameof(Remove):
                    Remove(nums, args);
                    break;

                case nameof(Shift):
                    Shift(nums, args);
                    break;

                case nameof(SumPairs):
                    nums = SumPairs(nums);

                    break;

                case nameof(Print):
                    Print(nums);
                    break;

                default:
                        Console.WriteLine("Invalid command!");
                    break;

           
            }
            

        }
    }

    private static void Print(List<int> nums)
    {
        Console.WriteLine(string.Join(", ", nums));
    }

    private static List<int> SumPairs(List<int> nums)
    {
        List<int> sumPairs = new List<int>();
        for (int i = 0; i < nums.Count; i += 2)
        {
            int firstNum = nums[i];
            int secondNum = (i + 1 < nums.Count) ? nums[i + 1] : 0;
            sumPairs.Add(firstNum + secondNum);
        }
        nums = sumPairs;
        return nums;
    }

    private static void Shift(List<int> nums, string[] arg)
    {
        int count = int.Parse(arg[1]);
        for (int i = 0; i < count; i++)
        {
            int firstElement = nums[0];
            nums.RemoveAt(0);
            nums.Add(firstElement);
        }
    }

    private static void Remove(List<int> nums, string[] arg)
    {
        int index = int.Parse(arg[1]);
        nums.RemoveAt(index);
    }

    private static void Contains(List<int> nums, string[] arg)
    {
        int element = int.Parse(arg[1]);
        int index = nums.FindIndex(x => x == element);
        Console.WriteLine(index);
    }

    private static void AddMany(List<int> nums, string[] arg)
    {
        int index = int.Parse(arg[1]);
        List<int> newItems = arg.Skip(2).Select(int.Parse).ToList();
        nums.InsertRange(index, newItems);
    }

    private static void Add(List<int> nums, string[] arg)
    {
        int index = int.Parse(arg[1]);
        int element = int.Parse(arg[2]);
        nums.Insert(index, element);
    }
}

