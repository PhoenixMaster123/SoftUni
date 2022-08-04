using System;

namespace T5___Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string player = Console.ReadLine();
             int score = 0;
             int playerscore = 0;
             while (player!="END")
             {

                 int goals = int.Parse(Console.ReadLine());
                 score += goals;
                 if(score>0)
                 {
                     playerscore += score;
                     if(playerscore>goals)
                     {

                     }
                 }

                 player = Console.ReadLine();

             }*/
                                        
                string player = Console.ReadLine();
                string newPlayer = "";
                int bestScore = 0;                
                while (player != "END")
                {
                    int currentGoals = int.Parse(Console.ReadLine());
                    if (currentGoals > bestScore)
                    {
                        newPlayer = player;
                        bestScore = currentGoals;
                    }

                    if (bestScore >= 10)
                    {
                        break;
                    }
                  player = Console.ReadLine();
                }

                Console.WriteLine($"{newPlayer} is the best player!");
                if (bestScore >= 3)
                {
                    Console.WriteLine($"He has scored {bestScore} goals and made a hat-trick !!!");
                }
                else
                {
                    Console.WriteLine($"He has scored {bestScore} goals.");
                }
            
        }
    }

}
    

