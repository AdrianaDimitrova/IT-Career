public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()!
            .Split(" ")
            .Select(int.Parse)
            .OrderBy(x => x)
            .ToList();

        List<int> uniqueNumbers = numbers.Distinct().ToList();
        foreach (var num in uniqueNumbers)
        {
            Console.WriteLine($"{num} -> {numbers.Count(x=> x==num)}");
        }
    }
}
