using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double average = 0;
            int gradecount = 0;
            double allgrade = 0;
            while(presentation!="Finish")
            {
                double sumGrade = 0;
                for(int i=1;i<=n;i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrade += grade;
                    gradecount++;
                    allgrade += grade;

                }
                double averagepresentation = sumGrade / n;
                Console.WriteLine($"{presentation} - {averagepresentation:F2}.");
                presentation = Console.ReadLine();
            }
            average = allgrade / gradecount;
            Console.WriteLine($"Student's final assessment is {average:F2}.");
        }
    }
}
