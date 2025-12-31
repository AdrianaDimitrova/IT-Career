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
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;


        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                count2++;
                
            }
            if (num % 3 == 0)
            {
                
                count3++;
            }
            if(num%4==0)
            {
                count4++;
                
            }
            
        }
        Console.WriteLine(count2);
        Console.WriteLine(count3);
        Console.WriteLine(count4);
    }
}

