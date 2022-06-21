using System;
using System.Linq;

namespace _02._Knights_of_Honor___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /////////////////////////////////////////////////////////////// First Variant //////////////////////////////////

            //string[] names = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();       
            //Action<string> appendSir = name => Console.WriteLine($"Sir {name}");      
            //foreach (var name in names)
            //{
            //    appendSir(name);
            //}
            /////////////////////////////////////////////////////////////// Second Variant //////////////////////////////////
            
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(name => Console.WriteLine("Sir " + name));
        }
    }
}
