using System;
using System.Linq;

namespace _01._Action_Print___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();         
            Action<string[]> print = name => Console.WriteLine(string.Join(Environment.NewLine, name));
            print(names);

           
        }
    }
}
