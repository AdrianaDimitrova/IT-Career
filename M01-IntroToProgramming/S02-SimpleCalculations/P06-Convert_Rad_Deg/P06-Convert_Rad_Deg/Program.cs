using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

 class Program
{
    private static void Main(string[] args)
    { 
        double radiani = double.Parse(Console.ReadLine());
        double gradusi = radiani * (180 / Math.PI );
        Console.WriteLine($"Gradusite sa {Math.Round(gradusi)}");
    }
}

