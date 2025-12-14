using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете две цели числа n и l, въведени от потребителя,
            //и генерира по азбучен ред всички възможни “тъпи” пароли, които се състоят от следните 5 символа:

            // •	Символ 1: цифра от 1 до n.
            //•	Символ 2: цифра от 1 до n.//•	Символ 3: малка буква измежду първите l букви на латинската азбука.
            //•	Символ 4: малка буква измежду първите l букви на латинската азбука.
            //	Символ 5: цифра от 1 до n, по-голяма от първите 2 цифри.

            //Input
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            // Action
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=n ; j++)
                {
                    for (int k = 'a'; k < ('a' + l); k++)
                    {
                        for (int m = 'a'; m <= ('a' + l); m++)
                        {
                            for (int o = 1; o <=n; o++)
                            {
                                if (o > i && o > j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)m}{o}");
                                }

                            }



                        }



                    }

                }

            }

















        }
    }
}
