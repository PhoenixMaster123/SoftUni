using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumleft = 0;
            int sumright = 0;
            for(int i=0;i<number;i++)
            {
                int current = int.Parse(Console.ReadLine());
                sumleft += current;
 
            }
            for(int i=0;i<number;i++)
            {
                int current = int.Parse(Console.ReadLine());
                sumright += current;
            }
            if(sumleft==sumright)
            {
                Console.WriteLine($"Yes, sum = {sumleft}");
            }
            else if(sumleft!=sumright)
            {
                int diff = sumleft - sumright;
                Console.WriteLine($"No, diff = {Math.Abs(diff)}");
            }
           
        }
    }
}
