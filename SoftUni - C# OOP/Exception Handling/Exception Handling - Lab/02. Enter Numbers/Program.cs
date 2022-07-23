//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace _02._Enter_Numbers
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int start = 1;
//            int end = 100;
//            int[] numbers = new int[10];
//            for (int i = 0; i < numbers.Length; i++)
//            {                

//                try
//                {
//                    numbers[i] = ReadNumber(start, end);


//                    if (numbers[i] <= start || numbers[i] > 100)
//                    {
//                        throw new IndexOutOfRangeException($"Your number is not in range {i + 1} - 100!");
//                    }
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("Invalid Number!");
//                    i--;
//                    continue;
//                }
//                catch (IndexOutOfRangeException inx)
//                {
//                    Console.WriteLine(inx.Message);
//                    i--;
//                    continue;
//                }


//                start = numbers[i];
//            }

//            Console.WriteLine(string.Join(", ",numbers));

//        }
//        public static int ReadNumber(int start, int end)
//        {
//            string input = Console.ReadLine();
//            int num;
//            while (!int.TryParse(input, out num))
//            {
//                throw new FormatException();
//            }
//            return num;
//        }

//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class Program
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {

                //array[i] = ReadNumber(start, end);

                try
                {
                    array[i] = ReadNumber(start, end);


                    if (array[i] <= start || array[i] > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                    i--;
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {i + 1} - 100!");
                    i--;
                    continue;
                }


                start = array[i];
            }

            //Console.Write("Your numbers are: ");
            //foreach (var n in array)
            //{
            //    Console.Write(n + ", ");
            //}
            //Console.WriteLine();
            Console.WriteLine(string.Join(", ", array));

        }
        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                throw new FormatException();
            }
            return num;
        }

    }
}


