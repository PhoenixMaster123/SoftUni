using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }
        static void PrintGrade(double note)
        {
            if (note >= 2.00 && note <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (note >= 3.00 && note <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (note >= 3.50 && note <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (note >= 4.50 && note <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
