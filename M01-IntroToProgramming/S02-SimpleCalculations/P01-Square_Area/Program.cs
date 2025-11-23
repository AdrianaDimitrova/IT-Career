using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
public  class Program
{
    private static void Main()
    {
        Console.WriteLine("Въведете стойност за страната а: ");
        int a = int.Parse(Console.ReadLine());
        int S = a * a;
        Console.WriteLine(S);
        Console.WriteLine($"The area is: {S}");

    }
}

