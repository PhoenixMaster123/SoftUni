using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] token = command.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                          
                string commandArg = token[0];

                if (commandArg == "Add")
                {
                    int addNumber = int.Parse(token[1]);
                    numbers.Add(addNumber);
                }
               
                else if (commandArg == "Insert")
                {
                    int insertNumber = int.Parse(token[1]);
                    int insertIndex = int.Parse(token[2]); 
                    //if (insertIndex < 0 || insertIndex >= numbers.Count) // There are equal
                    //{
                    //    Console.WriteLine("Invalid index");
                    //    continue;
                    //}
                    if (!isIndexValid(numbers, insertIndex)) // There are equal
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(insertIndex, insertNumber); 
                }
                else if (commandArg == "Remove")
                {
                    int deleteNumber = int.Parse(token[1]);

                    if (!isIndexValid(numbers, deleteNumber))  // няма разлика с предишния if
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(deleteNumber);
                }
                else if (commandArg == "Shift") 
                {
                    string direction = token[1];
                    int count = int.Parse(token[2]); 
                    
                    if(direction == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if(direction == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }


           
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
        static bool isIndexValid(List<int> numbers, int index)
        {
            return index >= 0 && index < numbers.Count;
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            int realPerformanceCount = count % numbers.Count;

            for (int i = 1; i <= realPerformanceCount; i++)
            {
                // int firstElement = numbers[0]; // First Variant //
                int firstElement = numbers.First(); // Second Variant //
                // We remove first element
                numbers.Remove(firstElement);
                // Then we append first element at last
                numbers.Add(firstElement);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {
            int realPerformanceCount = count % numbers.Count;

            for (int i = 1; i <= realPerformanceCount; i++)
            {
                // We take last element in order not to lose its value

                // int lastElement = numbers[numbers.Count - 1]; // First Variant //
                int lastElement = numbers.Last(); // Second Variant //

                // We remove last element
                //numbers.Remove(lastElement); // In some cases this might not be work
                numbers.RemoveAt(numbers.Count - 1);
                // Then we append first element at last
                numbers.Insert(0, lastElement);
            }
        }

    }
}
