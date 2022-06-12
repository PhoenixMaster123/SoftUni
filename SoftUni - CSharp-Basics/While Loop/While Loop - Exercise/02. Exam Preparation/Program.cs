using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failnotes = int.Parse(Console.ReadLine());
            int countfail = 0;
            string problem = Console.ReadLine();
            string lastproblem = "";
            int gradeSum = 0;
            int allgrades = 0;
            while(problem!="Enough")
            {
                int currentGrade = int.Parse(Console.ReadLine());
                gradeSum++;
                allgrades += currentGrade;               
                if(currentGrade<=4)
                {
                    countfail++;
                    if(countfail==failnotes)
                    {
                        break;
                    }
                }
                lastproblem = problem;
                problem = Console.ReadLine();
            }
            if(problem=="Enough")
            {
                double averagescore = 1.0 * allgrades / gradeSum;
                Console.WriteLine($"Average score: {averagescore:F2}");
                Console.WriteLine($"Number of problems: {gradeSum}");
                Console.WriteLine($"Last problem: {lastproblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {countfail} poor grades.");
            }


        }
    }
}
