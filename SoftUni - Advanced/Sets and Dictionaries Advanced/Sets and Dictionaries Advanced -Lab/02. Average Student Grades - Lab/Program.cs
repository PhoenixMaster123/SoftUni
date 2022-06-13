using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int GradesCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentInfo = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < GradesCount; i++)
            {
                string[] scholars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string names = scholars[0];
                decimal grade = Convert.ToDecimal(scholars[1]);

                if (!studentInfo.ContainsKey(names))
                {
                    studentInfo.Add(names, new List<decimal>() { grade });
                }
                else
                {
                    studentInfo[names].Add(grade);
                }
            }

            foreach (var student in studentInfo)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(' ', student.Value.Select(grade => grade.ToString("F2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}