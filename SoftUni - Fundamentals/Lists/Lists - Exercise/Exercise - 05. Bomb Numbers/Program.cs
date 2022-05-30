using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            //int indexOfBomb;
            //while((indexOfBomb = numbers.IndexOf(bombNumber)) >= 0)
            //{

            //}

            while (true)
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);
                if (indexOfBomb == -1)
                {
                    // There no more bombs inside the loop
                    break;
                }
                else
                {
                    DetonateBomb(numbers, indexOfBomb, bombPower);
                }
            }
            Console.WriteLine(numbers.Sum());


        }


        // For a single bomb
        static void DetonateBomb(List<int> numbers, int indexOfBomb, int bombPower)
        {

            int rightCount = indexOfBomb + bombPower;
            for (int i = indexOfBomb; i <= rightCount; i++)
            {
                if (indexOfBomb >= numbers.Count)
                {
                    break;
                }
                else
                {
                    numbers.RemoveAt(indexOfBomb);
                }
            }
            int leftCount = indexOfBomb - bombPower;
            if (leftCount < 0)
            {
                leftCount = 0;
            }
            for (int count = leftCount; count < indexOfBomb; count++)
            {
                if (leftCount >= numbers.Count)
                {
                    break;
                }
                else
                {
                    numbers.RemoveAt(leftCount);
                }

            }
        }
    }
}

