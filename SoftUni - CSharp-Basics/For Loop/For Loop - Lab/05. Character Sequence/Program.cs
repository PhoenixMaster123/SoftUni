using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
          for(int i =0;i<text.Length;i++)
            {
                char letter = text[i];
                Console.WriteLine(letter);
            }
        }
    }
}
