using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            bool hasChanges = false;
            while (command != "end")
            {
                string[] token = command.Split(' ');
                string action = token[0];
                if (action == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);
                    hasChanges = true;
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);
                    hasChanges = true;
                }
                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(token[1]);
                    numbers.RemoveAt(indexToRemove);
                    hasChanges = true;
                }
                else if (action == "Insert")
                {
                    int indexToInsertAdd = int.Parse(token[2]);
                    int elementToInsert = int.Parse(token[1]);
                    numbers.Insert(indexToInsertAdd, elementToInsert);
                    hasChanges = true;
                }
                else if (action == "Contains")
                {
                    int elementToCheck = int.Parse(token[1]);
                    if (numbers.Contains(elementToCheck))
                    {
                        Console.WriteLine("Yes");
                        
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                        
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                  
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                   
                }
                else if (action == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(string.Join(" ", sum));
                  
                }
                else if (action == "Filter") 
                {
                    string condition = token[1];
                    int numberOfComparison = int.Parse(token[2]);
                    List<int> result = GetFiltedNumbers(numbers,condition, numberOfComparison);
                    Console.WriteLine(string.Join(" ", result));
                    
                }
               
                command = Console.ReadLine();
            }

            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static List<int> GetFiltedNumbers(List<int> allNumbers,string condition,int numberToCompare)
        {
            if (condition == "<")
            {
               List<int> result =  allNumbers.FindAll(x => x < numberToCompare);
                return result;
            }
            else if (condition == ">")
            {
                List<int> result = allNumbers.FindAll(x => x > numberToCompare);
                return result;
            }
            else if (condition == "<=")
            {
                List<int> result = allNumbers.FindAll(x => x <= numberToCompare);
                return result;
            }
            else if(condition == ">=")
            {
                List<int> result = allNumbers.FindAll(x => x >= numberToCompare);
                return result;
            }
            else
            {
                return allNumbers;
            }
        }
    }
}
