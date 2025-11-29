using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    private const string Password = "s3cr3tP@ssw0rd";
    public static void Main(string[] args)
    {
        string UserPassword = Console.ReadLine();

        if (UserPassword == Password)
        {
            Console.WriteLine("Welcome!");
        }
        else 
        {
            Console.WriteLine("Wrong password!");
        }












    }
}

