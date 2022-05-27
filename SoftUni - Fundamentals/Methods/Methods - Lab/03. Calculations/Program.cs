using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            PrintNumber(command, num1, num2);

        }
        static void PrintNumber(string command, int num1,int num2)
        {
            double result = 0;
            if (command == "add")
            {
                result = num1 + num2;
            }
            else if (command == "multiply")
            {
                result = num1 * num2;
            }
            else if (command == "subtract")
            {
                result = num1 - num2;
            }
            else
            {
                result = num1 / num2;
            }
            Console.WriteLine(result);
        }




            //    string command = Console.ReadLine();
            //    int firstNimber = int.Parse(Console.ReadLine());
            //    int secondNumber = int.Parse(Console.ReadLine());

            //    switch (command)
            //    {
            //        case "add":
            //            Add(firstNimber, secondNumber);
            //            break;
            //        case "multiply":
            //            Multiply(firstNimber, secondNumber);
            //            break;
            //        case "subtract":
            //            Subtract(firstNimber, secondNumber);
            //            break;
            //        case "divide":
            //            Divide(firstNimber, secondNumber);
            //            break;
            //        default:
            //            break;
            //    }
            //}

            //static void Divide(int a, int b)
            //{
            //    Console.WriteLine(a / b);
            //}

            //static void Subtract(int a, int b)
            //{
            //    Console.WriteLine(a - b);
            //}

            //static void Multiply(int a, int b)
            //{
            //    Console.WriteLine(a * b);
            //}

            //static void Add(int a, int b)
            //{
            //    Console.WriteLine(a + b);
            //}
        
    }
}
   