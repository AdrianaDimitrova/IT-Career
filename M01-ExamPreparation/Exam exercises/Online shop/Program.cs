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
        double excursion = double.Parse(Console.ReadLine());
        int loveText = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int keys = int.Parse(Console.ReadLine());
        int caricaturs = int.Parse(Console.ReadLine());
        int luckSurpr = int.Parse(Console.ReadLine());

        double otstupka = 0;

        //Action
        double sum = loveText * 0.60 + roses * 7.20 + keys * 3.60 + caricaturs * 18.20 + luckSurpr * 22;
        int articuls = loveText + roses + keys + caricaturs + luckSurpr;

        if (articuls >= 25)
        {
            otstupka= sum * 0.35;
        }

        double totalPrice = sum - otstupka;
        double hostingPrice = totalPrice * 0.1;
        double income = totalPrice - hostingPrice;

        if (income > excursion)
        {
            Console.WriteLine($"Yes! {income - excursion:f2} lv left.");
        }
        else if (income<excursion)
        {
            Console.WriteLine($"Not enough money! {excursion-income:f2} lv needed.");
        }
    }
}

