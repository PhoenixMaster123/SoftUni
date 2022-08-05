using System;

namespace T3___Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());
            double sum = 0;
            double result = 0;

            if(size=="small")
            {
                if(fruit=="Watermelon")
                {
                    sum = 2 * 56.00;
                    result = sets * sum;
                }
                else if(fruit=="Mango")
                {
                    sum = 2 * 36.66;
                    result = sets * sum;
                }
                else if (fruit == "Pineapple")
                {
                    sum = 2 * 42.10;
                    result = sets * sum;
                }
                else if (fruit == "Raspberry")
                {
                    sum = 2 * 20.00;
                    result = sets * sum;
                }
            }
            else if (size == "big")
            {
                if (fruit == "Watermelon")
                {
                    sum = 5 * 28.70;
                    result = sets * sum;
                }
                else if (fruit == "Mango")
                {
                    sum = 5 * 19.60;
                    result = sets * sum;
                }
                else if (fruit == "Pineapple")
                {
                    sum = 5 * 24.80;
                    result = sets * sum;
                }
                else if (fruit == "Raspberry")
                {
                    sum = 5 * 15.20;
                    result = sets * sum;
                }
            }
            if (result >= 400 && result <= 1000)
            {
                result = result - result * 0.15;
            }
            else if (result > 1000) 
            {
                result = result - result * 0.5;
            }
            Console.WriteLine($"{result:F2} lv.");

        }
    }
}
