
using Microsoft.VisualBasic;

public class Program
{
    public static void Main(string[] args)
    {
       int n = int.Parse(Console.ReadLine());

        for (int number = 1; number <= n; number++)
        {
            int sum = 0;
            int currentNumber = number;

            while (currentNumber > 0)
            {
                int lastDigit = currentNumber % 10;
                sum += lastDigit;
                currentNumber /= 10;
            }

            bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{number} -> {isSpecial}");

        }


    }
}

