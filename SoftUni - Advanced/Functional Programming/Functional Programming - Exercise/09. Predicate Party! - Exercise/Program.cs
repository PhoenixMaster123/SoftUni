using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party____Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////// First Variant //////////////////////////////////////////////

            //    List<string> guests = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            //    string command = Console.ReadLine();

            //    while (command != "Party!")
            //    {
            //        string[] token = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //        string action = token[0];
            //        string condition = token[1];
            //        string argument = token[2];

            //        if (action.Equals("Remove"))
            //        {
            //            Predicate<string> predicate = GetPredicate(condition, argument);

            //            guests.RemoveAll(predicate);
            //        }
            //        else if (action.Equals("Double"))
            //        {
            //            Func<string, bool> filter = GetFilter(condition, argument);
            //            List<string> filteredNames = guests.Where(filter).ToList();

            //            guests.InsertRange(0, filteredNames);
            //        }

            //        command = Console.ReadLine();
            //    }

            //    if (guests.Any())
            //    {
            //        Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nobody is going to the party!");
            //    }
            //}

            //private static Func<string, bool> GetFilter(string criteria, string argument)
            //{
            //    if (criteria == "StartsWith")
            //    {
            //        return x => x.StartsWith(argument);
            //    }
            //    else if (criteria == "EndsWith")
            //    {
            //        return x => x.EndsWith(argument);
            //    }
            //    else if (criteria == "Length")
            //    {
            //        return x => x.Length == int.Parse(argument);
            //    }
            //    else
            //    {
            //        return x => true;
            //    }
            //}

            //private static Predicate<string> GetPredicate(string criteria, string argument)
            //{
            //    if (criteria == "StartsWith")
            //    {
            //        return x => x.StartsWith(argument);
            //    }
            //    else if (criteria == "EndsWith")
            //    {
            //        return x => x.EndsWith(argument);
            //    }
            //    else if (criteria == "Length")
            //    {
            //        return x => x.Length == int.Parse(argument);
            //    }
            //    else
            //    {
            //        return x => true;
            //    }
            //}


            ///////////////////////////////////////////////////////////////// Second Variant //////////////////////////////////////////////

            List<string> guests = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] token = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string action = token[0];
                string condition = token[1];
                string argument = token[2];

                Predicate<string> predicate = GetPredicate(condition, argument);

                if (action.Equals("Remove"))
                {
                    guests.RemoveAll(predicate);
                }
                else if (action.Equals("Double"))
                {
                    DoubleGuests(guests, predicate);
                }

                command = Console.ReadLine();
            }

            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void DoubleGuests(List<string> guests, Predicate<string> predicate)
        {
            for (int k = 0; k < guests.Count; k++)
            {
                string currentGuest = guests[k];

                if (predicate(currentGuest))
                {
                    guests.Insert(k + 1, currentGuest);
                    k++;
                }
            }
        }

        public static Predicate<string> GetPredicate(string condition, string argument)
        {
            Predicate<string> predicate = null;

            if (condition.Equals("StartsWith"))
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.StartsWith(argument);
                });
            }
            else if (condition.Equals("EndsWith"))
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.EndsWith(argument);
                });
            }
            else if (condition.Equals("Length"))
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.Length == int.Parse(argument);
                });
            }

            return predicate;
        }
    }
}
