using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> Students = new Dictionary<string, List<double>>();
            Dictionary<string, double> bestStudents = new Dictionary<string, double>();
            int countofStudents = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countofStudents; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!Students.ContainsKey(name))
                {
                    Students.Add(name, new List<double>());
                    Students[name].Add(grade);
                }
                else
                {
                    Students[name].Add(grade);
                }
            }
            foreach (var student in Students)
            {
                int countofGrade = student.Value.Count;
                double Sum = 0.00;
                for (int i = 0; i < countofGrade; i++)
                {
                    Sum += student.Value[i];
                }
                double averageGrade = Sum / countofGrade;
                if (averageGrade >= 4.50)
                {
                    bestStudents.Add(student.Key, averageGrade);
                }
            }
            foreach (var student in bestStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
    }

