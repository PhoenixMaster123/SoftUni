using System;

namespace _06._Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int win = 0;
            int lose = 0;
            int allwins = 0;
            int alloses = 0;
            double total = 0;
            double grandTotal = 0;
            string command;
            for (int i = 0; i < days; i++)
            {
                while((command = Console.ReadLine()) != "Finish")
                {
                    string sport = command;
                    string result = Console.ReadLine();
                    if(result == "win")
                    {
                        win++;
                        allwins++;
                        total += 20;
                    }
                    else
                    {
                        lose++;
                        alloses++;
                    }
                }
                if(win > lose)
                {
                    total += total * 0.10;
                    win = 0;
                    lose = 0;
                    grandTotal += total;
                    total = 0;
                }
                else
                {
                    win = 0;
                    lose = 0;
                    grandTotal += total;
                    total = 0;
                }
                
            }
            if (allwins > alloses) 
            {
                grandTotal += grandTotal * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {grandTotal:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {grandTotal:F2}");
            }
        }
    }
}
