using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 1; i <= n; i++)
            {
                string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currStudeFirstName = arr[0];
                string currStudeLastName = arr[1];
                double currStudentGrade = double.Parse(arr[2]);

                Student currStudent = new Student(currStudeFirstName, currStudeLastName, currStudentGrade);

                students.Add(currStudent);
            }
            List<Student> orderedStudent = students.OrderByDescending(s=>s.Grade).ToList();  //First Variant 
            //students=students.OrderByDescending(s=>s.Grade).ToList();                      //Second Variant  
            foreach (Student student in orderedStudent)
            {
                Console.WriteLine(student); // I can add hier ToString
            }

        }
    }
    class Student
    {
        public Student(string firstName,string lastName,double grade)
        {
            //Always called when new Student is being created
           this.FirstName = firstName;
           this.LastName = lastName;
           this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
    //Fields -> !
    //private string name;
    //Constructors -> !
    //Destructors(C++)
    //Properties -> !
    //public int Age { get; set; }
    //Methods(Behaviour)
}
