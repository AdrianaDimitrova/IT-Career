using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        // int[] nums = {15,20,12,3,45};

        double[] temp = new double[6];

        for (int i = 0; i < temp.Length; i++)
        {
            Console.Write("t[{i}] = ");
            temp[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < temp.Length; i++)
        {
            Console.WriteLine($"t[{i}] = {temp[i]}");
        }
    }
}

