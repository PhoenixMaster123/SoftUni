using System;

namespace _01._Train___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] number = new int[count];
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
                sum+=number[i];
                
            }
            Console.WriteLine(string.Join(" ", number));
            Console.WriteLine(sum);
            
        }
    }
}
