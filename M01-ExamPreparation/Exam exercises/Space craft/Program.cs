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
        double wide = double.Parse(Console.ReadLine());
        double lenght = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());
        double averageHight = double.Parse(Console.ReadLine());

        //Action
        double vCraft = wide * lenght * hight;
        double vRoom = (averageHight + 0.40) * 4;

        double people = Math.Floor(vCraft / vRoom);

        if (people >= 3 && people <= 10)
        {
            Console.WriteLine($"The spacecraft holds {people} astronauts.");
        }
        else if (people < 3)
        {
            Console.WriteLine($"The spacecraft is too small.");
        }
        else if (people > 10)
        {
            Console.WriteLine($"The spacecraft is too big.");
        }



    }
}

