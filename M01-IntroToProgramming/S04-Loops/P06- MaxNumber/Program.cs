using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int maxNum = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            
            if (number > maxNum)
            {
                number = maxNum;
            }
            
        }
        Console.WriteLine(maxNum);







    }
}

