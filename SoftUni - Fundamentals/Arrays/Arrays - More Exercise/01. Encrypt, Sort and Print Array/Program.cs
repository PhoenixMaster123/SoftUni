using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namesCount = int.Parse(Console.ReadLine());
            int sum = 0;
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < namesCount; i++)
            {
                string name = Console.ReadLine();

                char[] arr = name.ToCharArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == 'a' || arr[j] == 'e' || arr[j] == 'i' || arr[j] == 'u' || arr[j] == 'o' 
                       || arr[j] == 'A' || arr[j] == 'E' || arr[j] == 'I' || arr[j] == 'U' || arr[j] == 'O')
                    {
                        sum += arr[j] * arr.Length;
                        map[name] = sum;

                    }
                    else
                    {
                        sum += arr[j] / arr.Length;
                        map[name] = sum;
                    } 
                }
               
                sum = 0;
            }
            foreach (var result in map.OrderBy(x => x.Value))
            {
                Console.WriteLine(result.Value);
            }
        }
    }
}
