using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////// First Variant /////////////////////////////////////

            //    int namesLength = int.Parse(Console.ReadLine());
            //    List<string> names = Console.ReadLine().Split().ToList();
            //    names = names.Where(x => x.Length <= namesLength).ToList();
            //    Console.WriteLine(string.Join(Environment.NewLine, names));

            ///////////////////////////////////////////////////////// Second Variant /////////////////////////////////////
            
            int namesLength = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Predicate<string> filterByLength = name => name.Length > namesLength;
            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            names.RemoveAll(filterByLength);
            print(names);
        }
    }
}
