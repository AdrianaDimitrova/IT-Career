using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        double c = double.Parse(Console.ReadLine());
        double faranheit = c*1.8 +32;
        Console.WriteLine(faranheit);
    }
}

