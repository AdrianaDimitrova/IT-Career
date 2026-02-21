

public class Program
{
    public static void Main(string[] args)
    {
        string text = "Hello, World!";
        string text2 =  "                World              ";
        Console.WriteLine(text.ToLower());
        Console.WriteLine(text.ToUpper());
        Console.WriteLine(text.IndexOf("o"));
        Console.WriteLine(text.LastIndexOf("o"));
        Console.WriteLine(text.Replace("l", "*"));
        Console.WriteLine(text.Substring(7,5));
        Console.WriteLine(text.Remove(7,5));
        Console.WriteLine(text2.Trim());
        
    }
}

