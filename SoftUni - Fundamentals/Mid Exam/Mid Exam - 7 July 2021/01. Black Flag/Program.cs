using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunderForDay = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double dailyPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                dailyPlunder += plunderForDay;
                if (i % 3 == 0)
                {
                  
                    dailyPlunder += plunderForDay * 0.50;
                }
                if (i % 5 == 0)
                {
                   
                    dailyPlunder -= dailyPlunder * 0.30;
                }     
            }
            if(dailyPlunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {dailyPlunder:F2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {dailyPlunder / expectedPlunder * 100:F2}% of the plunder.");

            }

            
        }
    }
}
