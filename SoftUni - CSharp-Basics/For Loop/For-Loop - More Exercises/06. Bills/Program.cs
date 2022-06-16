using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            double sum = 0;
            double water = 0;
            double internet = 0;
            double other = 0;
            double average = 0;
            double result = 0;
            double result2 = 0;
            for (int i = 1; i <= month; i++)
            {
                double electrisity = double.Parse(Console.ReadLine());
                
                if(electrisity!=0)
                {
                    sum += electrisity;
                    water = month * 20;
                    internet = month * 15;
                    other = (electrisity + 20 + 15) * 1.2;
                }
                result += other;
            }
            result2 += result;
            average = (sum + water + internet + result2) / month;
            Console.WriteLine($"Electricity: {sum:F2} lv");
            Console.WriteLine($"Water: {water:F2} lv");
            Console.WriteLine($"Internet: {internet:F2} lv");
            Console.WriteLine($"Other: {result2:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");





        }
    }
}
