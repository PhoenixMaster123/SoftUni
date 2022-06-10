using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_1N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int count = 1;count<=num;count+=3)
            {

                Console.WriteLine(count);
                    
            }
        }
    }
}
