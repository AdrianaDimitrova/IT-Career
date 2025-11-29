using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        byte num1 = byte.Parse(Console.ReadLine());
        byte num2 = byte.Parse(Console.ReadLine());
        byte num3 = byte.Parse(Console.ReadLine());

        if (num1 == num2 && num2 == num3)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }


    }
}

