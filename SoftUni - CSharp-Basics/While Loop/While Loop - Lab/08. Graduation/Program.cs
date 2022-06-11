using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string name = Console.ReadLine();
            int grade = 12;
            int clas = 1;
            double average = 0;
            double fail = 0;
            for(int i=1;i<=12;i++)
            {
                double notes = double.Parse(Console.ReadLine());
                average += notes;
                if(notes>=4.00)
                {
                    clas++;
                    
                }
                else
                {
                    fail++;
                    if (fail >= 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {i} grade");
                        break;

                    }
                }
                
            }
            average = average / 12;
            if (average >= 4.00) { Console.WriteLine($"{name} graduated. Average grade: {average:F2}"); }*/
            string name = Console.ReadLine();

            double average = 0;
            double grade = 1;
            double fail = 0;
               
            while (grade<=12)
            {
                double notes = double.Parse(Console.ReadLine());
                if (notes < 4)
                {
                    fail++;
                    if (fail == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    continue;

                }
                average += notes;
                grade++;
                    
            }
            average = average / 12;
            if (grade > 12) 
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
            


        }
    }
}
