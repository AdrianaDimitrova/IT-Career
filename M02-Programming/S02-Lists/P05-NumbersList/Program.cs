
public class Program
{
    public static void Main(string[] args)
    {
        List<int> list = Console.ReadLine()!
            .Split(" ")
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .ToList();

        
        Console.WriteLine(string.Join(" ",list));



    }
}

