using System;
using System.Linq;

namespace _1.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            ListyIterator<string> listy = null;

            while ((command = Console.ReadLine()) != "END")
            {
                var tokens = command.Split();
                if (tokens[0] == "Create")
                {
                    listy = new ListyIterator<string>(tokens.Skip(1).ToArray());
                }
                else if (tokens[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (tokens[0] == "Print")
                {
                    try
                    {
                        listy.Print();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                else if (tokens[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
            }
        }
    }
}
