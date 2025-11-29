using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        byte hh = byte.Parse(Console.ReadLine());
        byte mm = byte.Parse(Console.ReadLine());

        mm += 15;

        if (mm >= 60 )
        {
            mm -= 60;
            hh++;

            if (hh > 23)
            {
                hh = 0;
            }
        }

        if (mm < 10)
        {
            Console.WriteLine($"{hh}:0{mm}");
        }
       
        else
        {
            Console.WriteLine($"{hh}:{mm}");
        }

        



    }
}

