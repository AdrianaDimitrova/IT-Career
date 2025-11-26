using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public class Program
{
    

    public static void Main()
    {
        List<string> Names1 = new List<string>() { "Адриана", "Дарислав", "Надя" };
        List<string> listNames2 = new List<string>() { "Петър", "Стоил", "Надя" };

        //сливане на двата листа
        Names1.AddRange(listNames2);

        foreach (string name in Names1)
        {
            Console.WriteLine(name);
        }

        // проверка за имената дали са на кирилица или латиница и дължината на името
        var result = Names1.Where(name => (name[0] >= 'A' && name[0] <= 'M' || name.Length > 6));

        // резлтат
        foreach (var name in result)
        {
            Console.WriteLine(name);
        }

    }

}


