using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    private const double BGNtoUSD = 1.79549;
    private const double BGNtoEUR = 1.95583;
    private const double BGNtoGBP = 2.53405;
    public static void Main(string[] args)
    {
        double value = double.Parse(Console.ReadLine());
        string from = Console.ReadLine();
        string to = Console.ReadLine();

        if (from == "BGN" && to == "EUR")
        {
           

        }
        else if (from == "EUR" && to == "BGN")
        {   // друг начин за по-кратко изписване
            result = value * BGNtoEUR;

        }
        // TODO: довършване на задачата
        
            




    }
}

