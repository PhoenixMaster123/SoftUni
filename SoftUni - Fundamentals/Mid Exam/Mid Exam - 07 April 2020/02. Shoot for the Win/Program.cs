using System;
using System.Linq;

namespace _02._Shoot_for_the_Win___07_April_2020
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int shootCounter = 0;

            while (command != "End")
            {
                int indexToShot = int.Parse(command);
                if (indexToShot >= 0 && indexToShot < targets.Length && targets[indexToShot] != -1)
                {
                    ShootTarget(indexToShot, targets);
                    shootCounter++;
                }
                //{
                //    var valueOfTarget = targets[indexToShot];
                //    if (valueOfTarget != -1)
                //    {
                //        targets[indexToShot] = -1;

                //        for (int i = 0; i < targets.Length; i++)
                //        {
                //            if(targets[i] == -1)
                //            {
                //                continue;
                //            }
                //            if(targets[i] > valueOfTarget)
                //            {
                //                targets[i] -= valueOfTarget;
                //            }
                //            else
                //            {
                //                targets[i]+=valueOfTarget;
                //            }
                //        }
                //    }
                command = Console.ReadLine();

            }

            Console.WriteLine($"Shot targets: {shootCounter} -> {string.Join(" ", targets)}");

        }

        private static void ShootTarget(int shootIndex, int[] targets)
        {
            var valueOfTarget = targets[shootIndex];

            targets[shootIndex] = -1;

            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] == -1)
                {
                    continue;
                }
                if (targets[i] > valueOfTarget)
                {
                    targets[i] -= valueOfTarget;
                }
                else
                {
                    targets[i] += valueOfTarget;
                }
            }
        }
    }
}
        
    
   