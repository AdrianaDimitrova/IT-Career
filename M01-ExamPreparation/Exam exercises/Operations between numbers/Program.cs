using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        double N1 = int.Parse(Console.ReadLine());
        double N2 = int.Parse(Console.ReadLine());
        string oper = Console.ReadLine();
        string evenOrOdd="";

        if (oper == "+" || oper == "-" || oper == "*")
        {
            double result = 0;
            if (oper == "+")
            {
                result = N1 + N2;
            }

            else if (oper == "-")
            {
                result = N1 - N2;
            }

            else if (oper == "*")
            {
                result = N1 * N2;
            }

            if (result % 2 == 0)
            {
                evenOrOdd = "even";
            }
            else
            {
                evenOrOdd = "odd";
            }
            Console.WriteLine($"{N1} {oper} {N2} = {result} – {evenOrOdd}");
        }

        else if (oper == "%")
        {
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }

            else
            {
                double result = N1 % N2;
                Console.WriteLine($"{N1} {oper} {N2} = {result}");
            }

        }

        else if (oper == "/")
        {
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }

            else
            {
                double result = N1 / N2;
                Console.WriteLine($"{N1} {oper} {N2} = {result}");
            }



        }


        


    }
}

