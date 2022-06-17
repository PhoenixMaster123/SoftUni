using System;

namespace T6___Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sum = 0;
           // double stop = 0;
            for (int i = 1; i <= days; i++)
            {
                double stop = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        stop += 2.50;
                       
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        stop += 1.25;
                    }
                    else
                    {
                        stop += 1;
                    }
                   
                }
                Console.WriteLine($"Day: {i} - {stop:F2} leva");
                sum += stop;
                
                
            }
            Console.WriteLine($"Total: {sum:F2} leva");
           
        }
    }
}
