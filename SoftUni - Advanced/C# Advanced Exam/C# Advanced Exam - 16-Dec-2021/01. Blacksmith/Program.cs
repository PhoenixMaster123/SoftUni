using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] steel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           int[] carbon = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           Queue<int> queueSteel = new Queue<int>(steel);
           Stack<int> stackCarbon = new Stack<int>(carbon);

            Dictionary<string, int> swords = new Dictionary<string, int>
            {
                {"Gladius",0},
                {"Shamshir",0},
                {"Katana",0},
                {"Sabre",0},
                {"Broadsword",0}
            };

            int countSworts = 0;

            while (queueSteel.Count > 0 && stackCarbon.Count > 0)
            {
                int steelElement = queueSteel.Peek();    // current steel
                int carbonElement = stackCarbon.Peek(); // current carbon

                int sum = steelElement + carbonElement;
             
                if (sum == 70)
                {
                    swords["Gladius"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    countSworts++;
                }
                else if (sum == 80)
                {
                    swords["Shamshir"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    countSworts++;
                }
                else if (sum == 90)
                {
                    swords["Katana"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    countSworts++;
                }
                else if(sum == 110)
                {
                    swords["Sabre"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    countSworts++;
                }
                else if(sum == 150)
                {
                    swords["Broadsword"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    countSworts++;
                }
                else
                {
                    queueSteel.Dequeue();
                    carbonElement += 5;
                    stackCarbon.Pop();
                    stackCarbon.Push(carbonElement);
                    
                }
            }

            if (countSworts >= 1) 
            {
                Console.WriteLine($"You have forged {countSworts} swords.");
            }
            else if(countSworts < 1)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (queueSteel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine("Steel left: " + string.Join(", ",queueSteel));
            }
            if (stackCarbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine("Carbon left: " + string.Join(", ", stackCarbon));
            }
            foreach (var item in swords.OrderBy(x => x.Key)) 
            {
                if(item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }


        }
    }
}
