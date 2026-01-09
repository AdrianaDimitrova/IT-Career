using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

public class Program
{
    public static void Main(string[] args)
    {
        int bitcoin = int.Parse(Console.ReadLine());
        double chineeseMoney = double.Parse(Console.ReadLine());
        double commission = double.Parse(Console.ReadLine());

        double bitcoinCostInLeva = 1168;
        double chineeseMoneyInDollars = 0.15;
        double DolarsInLeva = 1.76;
        double euroInLeva = 1.95;

        double bitcoinLeva = bitcoinCostInLeva * bitcoin;

        double yuansDollars = chineeseMoney * chineeseMoneyInDollars;
        double dollarsLeva = yuansDollars * DolarsInLeva;

        double totalLeva = bitcoinLeva + DolarsInLeva;

        double totalEuro = totalLeva / euroInLeva;

        double commissionProcent = totalEuro * (commission / 100);
        double finalEuro = totalEuro - commissionProcent;
        Console.WriteLine(finalEuro);

    }
}

