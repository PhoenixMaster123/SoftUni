using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////// First Variant ///////////////////////////////////////
            //List<int> numbers =Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //List <int> result = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if(numbers[i] < 0)
            //    {
            //        numbers.RemoveAt(i);
            //        i--;
            //    }
            //    else
            //    {
            //        result.Add(numbers[i]);
            //    }
            //}
            //result.Reverse();
            //if(result.Count == 0)
            //{
            //    Console.WriteLine("empty");
            //}
            //else
            //{
            //    Console.WriteLine(string.Join(" ",result));
            //}
            ///////////////////////////////////////////////////////// Second Variant //////////////////////////////////////
            List<int> numbers =Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.RemoveAll(x => x < 0);
            numbers.Reverse();
            if(numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}
