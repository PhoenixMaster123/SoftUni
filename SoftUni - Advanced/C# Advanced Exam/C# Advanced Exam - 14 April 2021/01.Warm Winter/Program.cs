using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hats = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] scarfs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stackHats = new Stack<int>(hats);
            Queue<int> queueScarfs = new Queue<int>(scarfs);

            Queue<int> result = new Queue<int>();
            
            int currentHat = stackHats.Peek();
            int currentScarf = queueScarfs.Peek();
            while (queueScarfs.Count > 0 && stackHats.Count > 0)
            {
                
                if(currentHat == currentScarf)
                {
                    currentHat++;
                    queueScarfs.Dequeue();
                    if (!queueScarfs.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentScarf = queueScarfs.Peek();
                    }                    
                }
                else if(currentHat > currentScarf)
                {
                    currentHat += currentScarf;
                    result.Enqueue(currentHat);
                    stackHats.Pop();
                    queueScarfs.Dequeue();
                    if (!stackHats.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentHat = stackHats.Peek();
                    }
                    if(!queueScarfs.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentScarf = queueScarfs.Peek();
                    }               
                }
                else if(currentHat < currentScarf)
                {
                    stackHats.Pop();
                    if (!stackHats.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentHat = stackHats.Peek();
                    }
                   
                }
                
            }
            int max = result.Max();
            Console.WriteLine($"The most expensive set is: {max}");
            Console.WriteLine(String.Join(" ",result));
           
        }
    }
}
