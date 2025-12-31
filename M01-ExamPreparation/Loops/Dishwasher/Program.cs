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
        int bottles = int.Parse(Console.ReadLine());
        int detergent = bottles * 750;

        int dishes = 0;
        int pots = 0;
        int load = 0;

        //Action
        string word = Console.ReadLine();

        while (true)
        {
            if (word == "End")
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
                break;
            }

            int num = int.Parse(word);
            load++;

            if (load == 3)
            {
                detergent -= num * 15;
                pots += num;
                load = 0;
            }
            else
            {
                detergent -= num * 5;
                dishes += num;
            }

            if (detergent < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
                break;
            }

            word = Console.ReadLine();


            

        }
    }
}

