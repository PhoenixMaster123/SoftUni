using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while(command !="end")
            {
                string[] token = command.Split(' ');
                string action = token[0];
                if(action=="Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);
                }
                else if(action=="Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(token[1]);
                    numbers.RemoveAt(indexToRemove);
                }
                else if (action == "Insert")
                {
                    int indexToInsertAdd = int.Parse(token[2]);
                    int elementToInsert = int.Parse(token[1]);
                    numbers.Insert(indexToInsertAdd, elementToInsert);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
