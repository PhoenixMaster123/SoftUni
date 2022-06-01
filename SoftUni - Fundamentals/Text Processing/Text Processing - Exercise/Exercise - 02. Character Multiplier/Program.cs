using System;

namespace Exercise___02._Character_Multiplier
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string str1 = input[0];
            string str2 = input[1];

            int minLen = Math.Min(str1.Length, str2.Length);
            int maxLen = Math.Max(str1.Length, str2.Length);
            int totalSum = 0;

            for (int i = 0; i < minLen; i++)
            {
                totalSum += MultiplyCharsASCII(str1[i], str2[i]);
            }

            if (str1.Length != str2.Length)
            {
                string longerInput = str1.Length > str2.Length ? longerInput = str1 : longerInput = str2;
                for (int i = minLen; i < maxLen; i++)
                {
                    totalSum += longerInput[i];
                }
            }
            Console.WriteLine(totalSum);
        }

        static int MultiplyCharsASCII(char let1, char let2)
        {
            int multiply = let1 * let2;
            return multiply;
        }
    }
}

