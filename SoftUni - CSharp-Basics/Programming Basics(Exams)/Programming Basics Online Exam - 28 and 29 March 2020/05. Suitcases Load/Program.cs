using System;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string command;
            int count = 0;
            int all = 0;
            while((command = Console.ReadLine()) != "End")
            {

                double volume = double.Parse(command);
                all++;
                if(all == 3)
                {
                    volume += volume * 0.10;
                }
                if(capacity >= volume)
                {
                    capacity -= volume;
                    count++;
                }
                else
                {
                    break;
                }
               
            }
            if(all > count)
            {
                Console.WriteLine($"No more space!\r\nStatistic: {count} suitcases loaded.\r\n");
                
            }
            else
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!\r\nStatistic: {count} suitcases loaded.\r\n");
            }
        }
    }
}
