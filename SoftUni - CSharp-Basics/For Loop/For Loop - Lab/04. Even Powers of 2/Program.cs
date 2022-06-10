using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for(int count = 0;count<=n;count+=2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }

        }
    }
}
