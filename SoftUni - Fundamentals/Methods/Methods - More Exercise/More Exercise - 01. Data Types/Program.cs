using System;

namespace More_Exercise___01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            if(command == "int")
            {
                int number = int.Parse(Console.ReadLine());
                int result = Multiply(number);
                Console.WriteLine(result);
            }
            else if(command == "real")
            {
                double number = double.Parse(Console.ReadLine());
                double result = Multiply(number);
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                string message = Console.ReadLine();
                string result = Multiply(message);
                Console.WriteLine($"${result}$");
            }
        }
        static int Multiply(int number)
        {
            int result = 0;
            result = number*2;
            return result;
        }
        static double Multiply(double number)
        {
            
            return number * 1.5;
        }

        static string Multiply(string command)
        {           
            return command;
        }
    }
}
