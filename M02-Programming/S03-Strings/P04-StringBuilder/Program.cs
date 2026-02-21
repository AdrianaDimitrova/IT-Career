using System.Text;
public class Program
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello,World!");
        sb[0] = 'h';
        sb[sb.Length - 1] = '.';
        sb.Append(" How are you?");
        sb.Insert(sb.ToString().IndexOf('.') + 1, "\nGreeting: ");
        Console.WriteLine(sb);
    }
}

