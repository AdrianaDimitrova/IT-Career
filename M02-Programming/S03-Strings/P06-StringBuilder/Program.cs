
using System.Text;

public class Program
{
    public static void Main()
    {
        string text = Console.ReadLine()!;
        StringBuilder sb = new StringBuilder(text);
        string[] input = Console.ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
        string cmd = input[0];
        switch (cmd)
        {
            case nameof(Append):
                Append(sb, input);
                break;

            case nameof(Remove):
                Remove(sb, input);
                break;

            case nameof(Insert):
                Insert(sb, input);
                break;

            case nameof(Replace):
                Replace(sb, input);
                break;

            default:
                Default();
                break;
        }
        Console.WriteLine(sb);



    }

    private static void Default()
    {
        Console.WriteLine("Invalid command");
    }

    private static void Replace(StringBuilder sb, string[] input)
    {
        string oldtext = input[1];
        string newtext = input[2];
        sb.Replace(oldtext, newtext);
    }

    private static void Insert(StringBuilder sb, string[] input)
    {
        int Insertindex = int.Parse(input[1]);
        string Inserttext = input[2];
        sb.Insert(Insertindex, Inserttext);
    }

    private static void Remove(StringBuilder sb, string[] input)
    {
        int index = int.Parse(input[1]);
        int count = int.Parse(input[2]);
        sb.Remove(index, count);
    }

    private static void Append(StringBuilder sb, string[] input)
    {
        string add = input[1];
        sb.Append(add);
    }
}

