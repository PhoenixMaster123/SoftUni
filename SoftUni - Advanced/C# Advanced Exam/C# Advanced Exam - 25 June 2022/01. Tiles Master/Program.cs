using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] areasWhiteTiles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] areasGreyTiles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stackWhite = new Stack<int>(areasWhiteTiles); // last white
            Queue<int> queueGray = new Queue<int>(areasGreyTiles); // first grey

            SortedDictionary<string, int> location = new SortedDictionary<string, int>()
            {
                {"Sink",0},
                {"Oven",0},
                {"Countertop",0},
                {"Wall",0},
                {"Floor",0}
            };

            int currentGreyTitle = queueGray.Peek();
            int currentWhiteTitle = stackWhite.Peek();
            int sum = 0;
            while (queueGray.Count > 0 && stackWhite.Count > 0)
            {
                if (currentGreyTitle == currentWhiteTitle)
                {
                    sum = currentGreyTitle + currentWhiteTitle;
                    if (sum == 40)
                    {
                        location["Sink"]++;
                        stackWhite.Pop();
                        queueGray.Dequeue();
                        if (!queueGray.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentGreyTitle = queueGray.Peek();
                        }
                        if (!stackWhite.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentWhiteTitle = stackWhite.Peek();
                        }
                    }
                    else if (sum == 50)
                    {
                        location["Oven"]++;
                        stackWhite.Pop();
                        queueGray.Dequeue();
                        if (!queueGray.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentGreyTitle = queueGray.Peek();
                        }
                        if (!stackWhite.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentWhiteTitle = stackWhite.Peek();
                        }
                    }
                    else if (sum == 60)
                    {
                        location["Countertop"]++;
                        stackWhite.Pop();
                        queueGray.Dequeue();
                        if (!queueGray.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentGreyTitle = queueGray.Peek();
                        }
                        if (!stackWhite.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentWhiteTitle = stackWhite.Peek();
                        }
                    }
                    else if (sum == 70)
                    {
                        location["Wall"]++;
                        stackWhite.Pop();
                        queueGray.Dequeue();
                        if (!queueGray.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentGreyTitle = queueGray.Peek();
                        }
                        if (!stackWhite.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentWhiteTitle = stackWhite.Peek();
                        }
                    }
                    else
                    {
                        location["Floor"]++;
                        queueGray.Dequeue();
                        stackWhite.Pop();
                        if (!queueGray.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentGreyTitle = queueGray.Peek();
                        }
                        if (!stackWhite.Any())
                        {
                            break;
                        }
                        else
                        {
                            currentWhiteTitle = stackWhite.Peek();
                        }

                    }

                }
                else
                {
                    stackWhite.Pop();
                    currentWhiteTitle /= 2;
                    stackWhite.Push(currentWhiteTitle);
                    queueGray.Dequeue();
                    queueGray.Enqueue(currentGreyTitle);
                    if(!queueGray.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentGreyTitle = queueGray.Peek();
                    }
                }
            }
            if (stackWhite.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: " + string.Join(", ", stackWhite));
            }
            if (queueGray.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: " + string.Join(", ", queueGray));
            }

            foreach (var item in location.OrderByDescending(x => x.Value))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }

            }
        }
    }
}
