using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int curentSum = numberOne + numberTwo;
            int curentDiff = 0;
            bool chek = true;

            for (int i = 0; i < countNumbers - 1; i++)
            {
                numberOne = int.Parse(Console.ReadLine());
                numberTwo = int.Parse(Console.ReadLine());
                int curent = numberOne + numberTwo;

                if (curent != curentSum)
                {
                    int diff = Math.Abs(curent - curentSum);
                    if (diff > curentDiff)
                    {
                        curentDiff = diff;
                    }
                    curentSum = curent;
                    chek = false;
                }
            }
            if (chek)
            {
                Console.WriteLine($"Yes, value={curentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={curentDiff}");
            }
            /*double number = double.Parse(Console.ReadLine());
            double sum = 0;
            double diff = 0;
            for(int i=1;i<=number;i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                sum = number1 + number2;
                for (int j = 1; j <= sum; j++)
                {
                    if (j == sum)
                    {

                        Console.WriteLine($"Yes, value = {sum}");
                    }
                    else if (j != sum)
                    {
                        diff = sum - number1 + number2;
                        Console.WriteLine($"No, maxdiff = {diff}");

                    }
                }*/
        }
        }
    }

