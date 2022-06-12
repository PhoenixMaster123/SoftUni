using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string search = Console.ReadLine();
            int count = 0;
            string book = Console.ReadLine();
            while(book!="No More Books")
            {
                if(book==search)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                count++;
                book = Console.ReadLine();
            }
            if (book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
