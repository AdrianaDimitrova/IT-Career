using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Program
{
    public static void Main(string[] args)
    {
        for (int n = 0; n < 6; n++)
        {
            Console.Write("Въведете име: ");
            string name = Console.ReadLine();

            bool endsWithVowel = false;


            for (int i = 0; i < name.Length; i++)
            {
                if (name[name.Length - 1] == name[i])
                {
                    endsWithVowel = true;
                    break;
                }
            }
            if (name.Length > 4 && endsWithVowel)
            {
                Console.WriteLine("Името има повече от 4 символа и завършва на гласна.");
            }
            else
            {
                Console.WriteLine("Едно или повече условия не са изпълнен");
            }
        }


    }







    
}

