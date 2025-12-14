using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_PizzaParty
{
    class Program
    {
        static void Main(string[] args)
        { // Input 
            int ukrasa = int.Parse(Console.ReadLine());

            // Action 
            double pizza = 2 * ukrasa;
            double drinks = pizza * 0.85;
            double boardGames =  (pizza + drinks) / 7.0;
            double TotalSum = ukrasa + drinks + boardGames;

            // Output
            Console.WriteLine($" Общата цена за разходите: {TotalSum:f2}");


        }
    }
}
