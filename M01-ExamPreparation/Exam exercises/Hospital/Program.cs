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
        int period = int.Parse(Console.ReadLine());

        int doctors = 7;
        int treatedPatients = 0;
        int untreatedPatients = 0;

        //Action
        for (int i = 1; i <= period; i++)
        {
            int patients = int.Parse(Console.ReadLine());

            if (i % 3 == 0 && untreatedPatients > treatedPatients)
            {
                doctors++;
            }

            int treatedToday = Math.Min(patients, doctors);
            treatedPatients += treatedToday;
            untreatedPatients += patients - treatedToday;

        }
        Console.WriteLine($"Treated patients: {treatedPatients}.");
        Console.WriteLine($"Untreated patients: {untreatedPatients}.");



    }
}

