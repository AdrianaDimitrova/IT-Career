using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        //Input
        int hrisantemsCount = int.Parse(Console.ReadLine());
        int rosesCount = int.Parse(Console.ReadLine());
        int tulipsCount = int.Parse(Console.ReadLine());
        int allFlowersCount = hrisantemsCount + rosesCount + tulipsCount; 
        string season = Console.ReadLine();
        string dayType = Console.ReadLine();

        double hrisantemsPrice = 0;
        double rosesPrice = 0;
        double tulipsPrice = 0;
        double allFlowersPrice = 0;


        //Action
        if (season == "Spring" || season == "Summer")
        {
            hrisantemsPrice = 2.00;
            rosesPrice = 4.1;
            tulipsPrice = 2.5;          
        }

        else if (season == "Autumn" || season == "Winter")
        {
            hrisantemsPrice = 3.75;
            rosesPrice = 4.5;
            tulipsPrice = 4.15;
        }

        allFlowersPrice = hrisantemsCount * hrisantemsPrice + rosesCount * rosesPrice + tulipsCount * tulipsPrice;

        if (dayType == "Y")
        {
            allFlowersPrice *= 1.15;
        }

        if (season == "Spring" && tulipsCount > 7)
        {
            allFlowersPrice *= 0.95;
        }

        if (season == "Winter" && rosesCount >= 10)
        {
            allFlowersPrice *= 0.90;
        }

        if (allFlowersCount > 20)
        {
            allFlowersPrice *= 0.80;
        }
        //Output
        double Total = allFlowersPrice + 2;
        Console.WriteLine($"{Total:f2}");




    }
}

