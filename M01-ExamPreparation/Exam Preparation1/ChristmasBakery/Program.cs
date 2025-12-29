using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Семейство си поръчва изделия от местната хлебопекарна за Коледа, която произвежда следните продукти:
            // питки, козунаци, гевреци и кроасани. Известни са следните зависимости между цените на продуктите: 
            //Козунакът е с 20 % по - скъп от цената на питката
            //Геврекът е с 40 % по - евтин от цената на козунакът
            //Кроасанът е с 1.20 лв.по - скъп от цената на геврека
            //Напишете програма, която изчислява дали бюджетът на семейството е достатъчен, според броя на всеки продукт.

            // Input
            double breadPrice = double.Parse(Console.ReadLine());
            int breadsCount = int.Parse(Console.ReadLine());
            int sweetbreadsCount = int.Parse(Console.ReadLine());
            int bagelsCount = int.Parse(Console.ReadLine());
            int croassantsCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            // Action 
            double sweetbreadPrice = breadPrice + (0.2*breadPrice);
            double bagelPrice = sweetbreadPrice - (0.4*sweetbreadPrice);
            double croassantPrice = bagelPrice + 1.2;

            // Output
            double totalPrice = (breadPrice * breadsCount) + (sweetbreadPrice * sweetbreadsCount) + (bagelPrice * bagelsCount) + (croassantPrice * croassantsCount);
            double money = (Math.Abs(totalPrice-budget));
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes!{money:f2} leva left.");
            }
            
            else if (budget < totalPrice)
            {
                Console.WriteLine($"No!{money:f2} leva need.");
            }




        }
    }
}
