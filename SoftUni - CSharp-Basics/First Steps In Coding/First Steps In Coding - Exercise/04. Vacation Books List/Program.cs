using System;

namespace _13._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int lists = int.Parse(Console.ReadLine());
            double listsforhour = double.Parse(Console.ReadLine());
            int daysofbooks = int.Parse(Console.ReadLine());

            double hours = lists / listsforhour;
            hours = hours / daysofbooks;
            Console.WriteLine(hours);
        }
    }
}
