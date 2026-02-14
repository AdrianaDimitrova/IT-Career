

using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {
        string[] products = Console.ReadLine()
            .Split(" ")
            .ToArray();

        long[] quantity = Console.ReadLine()
            .Split(" ")
            .Select(long.Parse)
            .ToArray();

        double[] price = Console.ReadLine()
            .Split(" ")
            .Select(double.Parse)
            .ToArray();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "done")
            {
                break;
            }

            int index = -1;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == input)
                {
                    index = i;
                    break;
                }
             
            }
            Console.WriteLine($"{products[index]} costs: {price[index]:f2}; Avaluable quantity: {quantity[index]}");
            
        }


    }
}

