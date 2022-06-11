using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            string num = Console.ReadLine();
            while (num != "Stop")
            {
                int number = int.Parse(num);
                if (min > number)
                {
                    min = number;

                }
                num = Console.ReadLine();

            }
            Console.WriteLine(min);
        }
    }
    }

