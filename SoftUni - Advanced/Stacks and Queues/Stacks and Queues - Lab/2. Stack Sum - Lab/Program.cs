using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stackNumbers = new Stack<int>(numbers);
            while(true)
            {
                string command = Console.ReadLine().ToLower();
                string[] token = command.Split(' ');
                string action = token[0];
                if(action.Equals("add"))
                {
                   
                    int number1 = int.Parse(token[1]);
                    int number2 = int.Parse(token[2]);                 
                    stackNumbers.Push(number1);
                    stackNumbers.Push(number2);

                }
                else if(action.Equals("remove"))
                {
                    int count = int.Parse(token[1]);
                    if(stackNumbers.Count>=count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stackNumbers.Pop();
                        }
                       
                    }
                }
                else if (command.Equals("end"))
                {
                    int sum = stackNumbers.Sum();
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
            }
           
           
           
            
        }
    }
}
