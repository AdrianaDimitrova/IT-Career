using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Фирма иска да организира пица парти за служителите си. Организаторите искат да разберат
            // колко ще са разходите по организирането на едно такова парти. Напишете програма, която изчислява какви разходи ще има фирмата по организацията на събитието,
            // като знаете колко ще е цената за украса на партито. 

            //Пица – цената и е два пъти по-висока от цената за украсата на партито

            //Напитки – цената им е с 15 % по - ниска от тази на пицата

            // Бордови игри – цената им 1 / 7 от сбора на цената за пица и напитки

            // Input and action
            double decoration = double.Parse(Console.ReadLine());
            double pizza = 2 * decoration;
            double drinks = 0.85*pizza;
            double boardGames = (pizza + drinks) / 7;

            // Output
            double totalPrice = decoration + pizza + drinks + boardGames;
            Console.WriteLine($"{totalPrice:f2}");
         
        }
    }
}
