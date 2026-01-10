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
        int students = int.Parse(Console.ReadLine());

        int topStudents = 0;
        int between4 = 0;
        int between3 = 0;
        int fail = 0;

        double sumGrades = 0;
        //Action
        for (int i = 0; i < students; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            sumGrades += grade;
            
            if (grade >= 5.00)
            {
                topStudents++;
            }
            else if (grade >= 4.00)
            {
                between4++; 
            }
           else  if (grade >= 3.00)
            {
                between3++;
            }
            else
            {
                fail++;
            }


        }

        Console.WriteLine($"Top students: {topStudents*100.00/students:f2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {between4*100.0/students:f2}");
        Console.WriteLine($"Between 3.00 and 3.99: {between3*100.0/students:f2}%");
        Console.WriteLine($"Fail: {fail*100.0/students:f2}%");
        Console.WriteLine($"Average: {sumGrades/students:f2}");
    }
}

