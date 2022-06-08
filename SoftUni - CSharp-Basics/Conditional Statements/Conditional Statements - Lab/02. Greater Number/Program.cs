using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int secoundnumber = int.Parse(Console.ReadLine());

            if (number > secoundnumber)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(secoundnumber);
            }

        }
    }
}
