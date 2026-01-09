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
        int workingDays = int.Parse(Console.ReadLine());
        double earnMoney = double.Parse(Console.ReadLine());
        double dollarToLev = double.Parse(Console.ReadLine());

        //Action
        double salary = workingDays * earnMoney;
        double earnInYear = salary * 12 + salary * 2.5;
        double tax = 0.25 * earnInYear;
        double totalEarnInYear = earnInYear - tax;

        double earnYearInLeva = totalEarnInYear * dollarToLev;

        double averageSalaryPerDay = earnYearInLeva / 365;

        Console.WriteLine($"{averageSalaryPerDay:f2}");
    }
}

