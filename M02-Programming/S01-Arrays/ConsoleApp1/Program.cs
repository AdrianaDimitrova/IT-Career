

public class Program
{
    public static void Main(string[] args)
    {
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine($"{word[i]} -> {((int)word[i] - 'a')}");
        }
    }
}

