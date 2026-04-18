using System.Runtime.CompilerServices;

public class Program
{
    private static Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
    private static Dictionary<string, Car> cars = new Dictionary<string, Car>();

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string model = input[0];
            double power = double.Parse(input[1]);
            int displacement = 0;
            string efficiency = "n/a";
            Engine engine = null;

            if (input.Length == 3)
            {
                if (double.TryParse(input[2], out double displacement))
                {
                    displacement = double.Parse(input[2]);
                }
                else
                {
                    string efficiency = input[2];

                }
            }
            else if (input.Length == 4)
            {
                double displacement = double.Parse(input[2]);
                string efficiency = input[3];

            }

            if (!engines.ContainsKey(model))
            {
                engines.Add(model, new Engine(model, power, displacement, efficiency));
            }

        }

        int m = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string model = input[0];
            string engineModel = input[1];
            int weight = 0;
            string color = "n/a";
            Car car = null;
            if (input.Length == 3)
            {
                if (int.TryParse(input[2], out int weight))
                {
                    weight = int.Parse(input[2]);
                }
                else
                {
                    string color = input[2];

                }
            }
            else if (input.Length == 4)
            {
                int weight = int.Parse(input[2]);
                string color = input[3];

            }
            if (!cars.ContainsKey(model))
            {
                cars.Add(model, new Car(model, engines[engineModel], weight, color));
            }
        }

        foreach (var car in cars.Values)
        {
            Console.WriteLine(car);


        }
    }
}

