using System.Net.Http.Headers;

public class Program
{
    public static void Main()
    {
        //Input
        int people = int.Parse(Console.ReadLine()!);

        int[] lift = Console.ReadLine()!
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        //Output
        for (int i = 0; i < lift.Length; i++)
        {
            while (lift[i] < 4 && people > 0)
            {
                lift[i]++; // Add a person to the current wagon
                people--; // Decrease the number of people waiting
            }
        }

        if (people == 0 && lift.Any(x => x < 4))
        {
            Console.WriteLine("The lift has empty spots!");
        }
        else if (people > 0 && lift.All(x => x == 4))
        {
            Console.WriteLine($"There isn't enough space! {people} people in a queue!");
        }

        Console.WriteLine(string.Join(" ",lift));

    }
}

