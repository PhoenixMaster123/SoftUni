using System;
using System.Collections.Generic;

namespace _04._Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while(command != "end")
            {
                string[] tokens = command.Split(' ');
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];
                Student student = new Student();
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                students.Add(student);
                command = Console.ReadLine();

            }
            string homeTownToSearch = Console.ReadLine();
            List<Student> filteredStudents = students.FindAll(students => students.HomeTown == homeTownToSearch);
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
