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
        string text = Console.ReadLine();

        //Action
        if (text == "sunny")
        {
            Console.WriteLine("It's warm outside!");
        }
        else if (text == "cloudy" || text == "snowy")
        {
            Console.WriteLine("It's cold outside!");
        }



    }
}

