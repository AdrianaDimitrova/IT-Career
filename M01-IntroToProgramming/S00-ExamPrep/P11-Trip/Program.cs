using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Странно, но повечето хора си плануват от рано почивката. Млад програмист разполага с определен бюджет и свободно време в даден сезон. Напишете програма, която да приема на входа бюджета и сезона, а на изхода да изкарва, къде ще почива програмиста и колко ще похарчи.

            //Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. Ако е лято ще почива на къмпинг, а зимата в хотел. Ако е в Европа, независимо от сезона ще почива в хотел. Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета:

            //При 100лв.или по-малко – някъде в България
            //Лято – 30 % от бюджета
            //Зима – 70 % от бюджета
            //При 1000лв.или по малко – някъде на Балканите
            //Лято – 40 % от бюджета
            //Зима – 80 % от бюджета
            //При повече от 1000лв. – някъде из Европа
            //При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.

            // Input 
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // Output
            string destination = string.Empty;
            string place = string.Empty;
            double price = 0.0;
            if (budget <= 1000)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "camp";
                    price = budget * 0.3;

                }
                else if (season == "winter")
                {
                    place = "hotel";
                    price = budget * 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "camp";
                    price = budget * 0.4;

                }
                else if (season == "winter")
                {
                    place = "hotel";
                    price = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                
                    place = "hotel";
                    price = budget * 0.9;            
            }

            // Output
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} – {price:f2}");
            














        }
    }
}
