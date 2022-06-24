using System;

namespace _5.Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.GetDiffBetweendatesInDays(firstDate,secondDate);
            Console.WriteLine(days);
        }
    }
}
