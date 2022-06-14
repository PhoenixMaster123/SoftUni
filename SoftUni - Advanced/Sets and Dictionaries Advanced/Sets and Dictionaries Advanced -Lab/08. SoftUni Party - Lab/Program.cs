using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guests = Console.ReadLine();
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();
            while (guests!="PARTY")
            {
                char digit = guests[0];
                if (!vipGuests.Contains(guests) && guests.Length == 8 && char.IsDigit(digit))
                {
                    vipGuests.Add(guests);
                }
                else
                {
                    regularGuests.Add(guests);
                }


                guests = Console.ReadLine();
            }
            while (guests != "END")
            {
                char digit = guests[0];
                if (char.IsDigit(digit))
                {
                    vipGuests.Remove(guests);
                }
                else
                {
                    regularGuests.Remove(guests);
                }


                guests = Console.ReadLine();
            }
            int noShow = vipGuests.Count + regularGuests.Count;
            Console.WriteLine(noShow);

            if (vipGuests.Count > 0)
            {
                foreach (var guest in vipGuests)
                {
                    Console.WriteLine(guest);
                }
            }

            if (regularGuests.Count > 0)
            {
                foreach (var guest in regularGuests)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
