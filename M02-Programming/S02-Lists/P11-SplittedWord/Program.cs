
public class Program
{
    public static void Main(string[] args)
    {
        char[] splite = { ',', ';', ':', '.', '!', '(', ')', '"', '\', '\\', '/', '[', ']' '};
        List<string> words = Console.ReadLine()!
            .Split(splite, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> lowerWords = words.Where(x=> !x.Any(a=> char.IsUpper(x))).ToList();
        Console.WriteLine(string.Join(", ",lowerWords));
    }
}

