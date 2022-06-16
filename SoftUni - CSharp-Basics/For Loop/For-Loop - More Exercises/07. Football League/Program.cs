using System;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double capasity = int.Parse(Console.ReadLine());
            double fans = int.Parse(Console.ReadLine());           
            double fansA = 0;
            double fansB = 0;
            double fansV = 0;
            double fansG = 0;
            double allFans = 0;
          
            for(int i=1;i<=fans;i++)
            {
                string team = Console.ReadLine();
                if (team == "A")
                {
                    fansA++;
                }
                else if (team == "B") 
                {
                    fansB++;
                }
                else if (team == "V")
                {
                    fansV++;
                }
                else
                {
                    fansG++;
                }

            }
            fansA = fansA / fans * 100;
            fansB = fansB / fans * 100;
            fansV = fansV / fans * 100;
            fansG = fansG / fans * 100;
            allFans = fans / capasity*100;
            Console.WriteLine($"{fansA:F2}%");
            Console.WriteLine($"{fansB:F2}%");
            Console.WriteLine($"{fansV:F2}%");
            Console.WriteLine($"{fansG:F2}%");
            Console.WriteLine($"{allFans:F2}%");

        }
    }
}
