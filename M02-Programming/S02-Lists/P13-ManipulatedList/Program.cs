using Microsoft.VisualBasic.FileIO;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine()!
            .Split(" ")
            .Select(int.Parse)
            .ToList();

        while (true)
        {
            string[] input = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string command = input[0];

            if (command == "Delete")
            {
                int item = int.Parse(input[1]);
                nums.RemoveAll(x => x == item);
            }
            else if (command == "Insert")
            {
                int item = int.Parse(input[1]);
                int index = int.Parse(input[2]);
                if (index >= 0 && index <= nums.Count)
                    nums.Insert(index, item);
            }
            else if (command == "Even")
            {
                Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 == 0)));
                break;
            }
            else if (command == "Odd")
            {
                Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 != 0)));
                break;
            }
        }

    }
}
    

