using System;

namespace _03._Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggSize = Console.ReadLine();
            string eggColor = Console.ReadLine();
            int eggCount = int.Parse(Console.ReadLine());
            int total = 0;
            if(eggSize == "Large")
            {
                if(eggColor == "Red")
                {
                    total = eggCount * 16;
                }
                else if(eggColor == "Green")
                {
                    total = eggCount * 12;
                }
                else
                {
                    total = eggCount * 9;
                }
            }
            else if(eggSize == "Medium")
            {
                if (eggColor == "Red")
                {
                    total = eggCount * 13;
                }
                else if (eggColor == "Green")
                {
                    total = eggCount * 9;
                }
                else
                {
                    total = eggCount * 7;
                }
            }
            else
            {
                if (eggColor == "Red")
                {
                    total = eggCount * 9;
                }
                else if (eggColor == "Green")
                {
                    total = eggCount * 8;
                }
                else
                {
                    total = eggCount * 5;
                }
            }
            double result = total - total * 0.35;
            Console.WriteLine($"{result:F2} leva.");
        }
    }
}
