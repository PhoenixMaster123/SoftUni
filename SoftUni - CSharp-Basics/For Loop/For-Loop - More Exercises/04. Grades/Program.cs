using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double lowgrade = 0;
            double dgrade = 0;
            double midiumgrade = 0;
            double highgrade = 0;
            double notes = 0;
            double average = 0;
            for(int i=1;i<=students;i++)
            {
                double grades = double.Parse(Console.ReadLine());
                notes += grades;
                if (grades>=2.00&&grades<=2.99)
                {
                    lowgrade++;
                    
                }
                else if (grades >= 3.00 && grades <= 3.99)
                {
                    dgrade++;
                    
                }
                else if (grades >= 4.00 && grades <= 4.99)
                {
                    midiumgrade++;
                   
                }
                else
                {
                    highgrade++;
                    
                }

            }
            lowgrade=(lowgrade / students) * 100 ;
            dgrade = (dgrade / students) * 100;
            midiumgrade = (midiumgrade / students) * 100;
            highgrade = (highgrade / students) * 100; 
            average = notes / students;
            Console.WriteLine($"Top students: {highgrade:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {midiumgrade:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {dgrade:F2}%");
            Console.WriteLine($"Fail: {lowgrade:F2}%");
            Console.WriteLine($"Average: {average:F2}");

        }
    }
}
