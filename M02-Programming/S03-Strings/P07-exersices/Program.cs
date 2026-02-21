
using System.Text;

public class Program
{
    public static void Main()
    {
        double priceWithoutTax = 0;
        string clientType = Console.ReadLine()!;

        while (clientType != "special" && clientType != "regular")
        {
            double price = double.Parse(clientType);
            if (price <= 0)
            {
                Console.WriteLine("Invalid price!");
                
            }
            else
            {
                priceWithoutTax += price;
            }
            clientType = Console.ReadLine()!;
        }

        if (priceWithoutTax == 0)
        {
            Console.WriteLine($"Invalid order!");
            return;

        }

        double taxes = priceWithoutTax * 0.2;
        double totalPrice = priceWithoutTax + taxes;

        if (clientType == "special")
        {
            totalPrice *= 0.9;
        }

        Console.WriteLine($"Congratulations, you just bought a new computer!");
        Console.WriteLine($"Price excluding tax: {priceWithoutTax:f2}$");
        Console.WriteLine($"Taxes: {taxes:f2}$");
        Console.WriteLine($"-----------");
        Console.WriteLine($"Total price: {totalPrice:f2}$");



    }
}

