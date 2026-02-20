
   public class Program
    {
       public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()!
                .Split(" ")
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToList();

        Console.WriteLine(string.Join(" <= ", numbers));
    }
    }

