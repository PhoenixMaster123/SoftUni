using System;

namespace _06._Easter_Decoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int customers = int.Parse(Console.ReadLine());
            double sum = 0;
            double total = 0;
            int count = 0;
            for (int i = 0; i < customers; i++)
            {
                while(true)
                {
                    string products = Console.ReadLine();
                    if(products == "Finish")
                    {
                        if(count %2 == 0)
                        {
                            sum = sum - sum * 0.20;
                        }
                        total += sum;
                        Console.WriteLine($"You purchased {count} items for {sum:F2} leva.");
                        sum = 0;
                        count = 0;
                        break;
                    }    
                    if(products == "basket")
                    {
                        sum += 1.50;
                        count++;
                    }
                    else if(products == "wreath")
                    {
                        sum += 3.80;
                        count++;
                    }
                    else if(products == "chocolate bunny")
                    {
                        sum += 7;
                        count++;
                    }
                }    
            }
            Console.WriteLine($"Average bill per client is: {total/customers:F2} leva.");
        }
    }
}
