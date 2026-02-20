public class Program
{
    public static void Main(string[] args)
    {
       List<int> numbers = Console.ReadLine()!
            .Split(" ")
            .Select(int.Parse)
            .Where(x => Math.Sqrt(x) == (int)Math.Sqrt(x))
            .OrderByDescending(x => x)
            .ToList();

        Console.WriteLine(string.Join(" ",numbers));


        
        
    }
}

