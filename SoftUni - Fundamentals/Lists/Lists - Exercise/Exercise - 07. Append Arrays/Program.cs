using System;
using System.Collections.Generic;
using System.Linq;
namespace listExer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> listOfLists = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();

            for (int i = listOfLists.Count - 1; i >= 0; i--)
            {
                var currentList = listOfLists[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in currentList)
                {
                    result.Add(item);
                }

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
