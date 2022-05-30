using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < num.Count / 2; i++)
            { 
                int newElement = num[i] + num[num.Count - 1 - i];
                result.Add(newElement);
                
            }
            if(num.Count % 2 != 0)
            {
                result.Add(num[num.Count / 2]);
            }
            Console.WriteLine(string.Join(' ',result));
           

        }
    }
}
