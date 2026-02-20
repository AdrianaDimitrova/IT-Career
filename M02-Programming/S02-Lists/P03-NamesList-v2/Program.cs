namespace P03_NamesList_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();

            for (int i = names.Count - 1; i >= 0; i--)
            {
                List<string> reversedNames = names[i]
                    .Split(" ")
                    .Reverse()
                    .ToList();
                Console.WriteLine(string.Join(" ", reversedNames));
            }
        }
    }
}
