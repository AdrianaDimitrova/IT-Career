using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine(num1 );
        }
        else if (num2 < num1)
        {
            Console.WriteLine(num2);
        }
        else
        {
            Console.WriteLine(num2);
        }
    }
}

