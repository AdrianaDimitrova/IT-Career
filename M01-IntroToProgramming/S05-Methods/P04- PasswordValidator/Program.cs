using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Program
{
    public static void Main(string[] args)
    {
        string password = Console.ReadLine();
        Console.WriteLine(IsValidLenght("48564578"));

    }
    public static bool IsValidLenght(string password)
    {
        if (password.Length >= 6 && password.Length <= 10)
        {
            return  true;
        }
        return false;
    }
   
}

