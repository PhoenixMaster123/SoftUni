using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstscore = int.Parse(Console.ReadLine());
            double bonusscore = 0.0;
            
            if(firstscore<=100)
            {
                bonusscore = 5;
               // int total = firstscore + bonusscore;
                
            }
            else if (firstscore <= 100)
            {
                bonusscore = 5;
                //int total = firstscore + bonusscore;
               
            }
            else if (firstscore > 1000)
            {
                bonusscore = firstscore * 0.1;
               // int total = firstscore + bonusscore;
                
            }
            else
            {
                bonusscore = firstscore * 0.2;
            }
            if (firstscore % 2 == 0)
            {

                bonusscore += 1;
            }
            else if (firstscore % 10 == 5) 
            {
                
                bonusscore += 2;
            }
            Console.WriteLine(bonusscore);
            Console.WriteLine(firstscore + bonusscore);

        }
    }
}
