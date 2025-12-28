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
        string name = Console.ReadLine();
        int days = int.Parse(Console.ReadLine());
        int tickets = int.Parse(Console.ReadLine());
        double ticketprice = double.Parse(Console.ReadLine());
        double procentCinema = double.Parse(Console.ReadLine());

        //Action
        double ticketPriceForDay = tickets * ticketprice;
        double income = days * ticketPriceForDay;
        double procentIncome = income * procentCinema / 100;

        double incomeFromFilm = income - procentIncome;

        //Output
        Console.WriteLine($"The profit from the movie {name} is {incomeFromFilm} lv.");

    }
}

