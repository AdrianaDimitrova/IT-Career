using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        //Input
        int juniors = int.Parse(Console.ReadLine());
        int seniors = int.Parse(Console.ReadLine());
        string trace = Console.ReadLine();

        double fee = 0;
        double expenses = 0;
        double leftMoney = 0;

        //Action
        if (trace == "trail")
        {
            fee = juniors * 5.50 + seniors * 7;
            expenses = 0.05 * fee;
            leftMoney = fee - expenses;
            Console.WriteLine($"{leftMoney:f2}");
        }

        else if (trace == "cross-country")
        {

            fee = juniors * 8 + seniors * 9.5;
            if (juniors + seniors > 50)
            {
                fee *= 0.75;
            }
            expenses = 0.05 * fee;
            leftMoney = fee - expenses;
            Console.WriteLine($"{leftMoney:f2}");
        }

        else if (trace == "downhill")
        {
            fee = juniors * 12.25 + seniors * 13.75;
            expenses = 0.05 * fee;
            leftMoney = fee - expenses;
            Console.WriteLine($"{leftMoney:f2}");
        }

        else if (trace == "road")
        {
            fee = juniors * 20 + seniors * 21.50;
            expenses = 0.05 * fee;
            leftMoney = fee - expenses;
            Console.WriteLine($"{leftMoney:f2}");
        }









    }
}

