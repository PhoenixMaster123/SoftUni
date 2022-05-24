using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int equal = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (equal == numbers[i] + numbers[j])
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }
            }
        }
    }
}
























//using System;
//using System.Linq;

//namespace _08._Magic_Sum
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int equal = int.Parse(Console.ReadLine());
//            int second = numbers[0];
//            int sum = 0;
//            int count = 0;

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                if (equal == numbers[i])
//                {
//                    Console.WriteLine(String.Join(" ", numbers));
//                }
//                else
//                {

//                    sum += numbers[i];
//                }
//                if (sum == equal)
//                {
//                    Console.WriteLine(String.Join(" ", second, numbers[i]));
//                    count++;
//                    sum = 0;
//                }
//                if (count >= 1)
//                {
//                    second = numbers[i];
//                }



//            }
//        }
//    }
//}
