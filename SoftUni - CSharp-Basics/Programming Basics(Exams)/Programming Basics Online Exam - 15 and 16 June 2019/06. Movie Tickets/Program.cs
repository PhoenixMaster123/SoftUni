using System;

namespace _06._Movie_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char symbol1;
            int symbol2;
            int symbol3;
            int symbol4;
            for (int i = a1; i <= a2-1; i++)
            {
                
                symbol1 = (char)i;
                for (int k = 1; k <= n - 1; k++)
                {
                    symbol2 = k;
                    for (int x = 1; x <= n / 2 - 1; x++)
                    {
                        symbol3 = x;
                        symbol4 = (int)symbol1;
                        if (symbol4 % 2 != 0)
                        {
                            if ((x + k + i) % 2 == 1 && i % 2 == 1)
                            {
                                Console.WriteLine($"{symbol1}-{symbol2}{symbol3}{symbol4}");
                            }
                           
                        }
                    }
                }
               
            }    
        }
    }
}
