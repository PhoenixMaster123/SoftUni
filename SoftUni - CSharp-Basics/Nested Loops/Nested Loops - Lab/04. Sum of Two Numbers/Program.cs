using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());            
            int magicnumber = int.Parse(Console.ReadLine());
            int counter = 0;           
            bool flag = false;
            for (int i = firstnumber; i <= secondnumber; i++)
            {
                for (int j = firstnumber; j <= secondnumber; j++)
                {
                    counter++;
                    int sum = i + j;
                    if (sum == magicnumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicnumber})");
                        flag = true;
                        break;
                        // return;
                    }

                }
                if (flag)
                {
                    break;
                }
            }
                if (!flag)
                { Console.WriteLine($"{counter} combinations - neither equals {magicnumber}"); }             
                       
        }

    }
}
