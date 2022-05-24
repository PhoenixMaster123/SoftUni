using System;

namespace _02._Common_Elements___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] arr1 = input1.Split();
            string[] arr2 = input2.Split();


            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        Console.Write(arr2[i] + " ");
                    }


                }
            }

            Console.WriteLine();
        }
    }
}
