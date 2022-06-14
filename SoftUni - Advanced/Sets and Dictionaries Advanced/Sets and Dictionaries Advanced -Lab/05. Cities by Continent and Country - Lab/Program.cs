//using System;
//using System.Collections.Generic;

//class CitiesByContinentAndCountry
//{
//    static void Main()
//    {
//////////////////////////////////////////////////////////////////////// First Variant ////////////////////////////////////////

//        var states = new Dictionary<string, Dictionary<string, List<string>>>();
//        int citiesCount = int.Parse(Console.ReadLine());
//        for (int i = 0; i < citiesCount; i++)
//        {
//            string[] token = Console.ReadLine().Split(" ");
//            string continent = token[0];
//            string country = token[1];
//            string city = token[2];
//            // Add the continent (if missing)
//            if (!states.ContainsKey(continent))
//            {
//                states.Add(continent, new Dictionary<string, List<string>>());
//            }

//            // Add the country inside the continent (if missing)
//            Dictionary<string, List<string>> countries = states[continent];
//            if (!countries.ContainsKey(country))
//            {
//                countries.Add(country, new List<string>());
//            }


//            // Add the city in the existing continent --> country
//            countries[country].Add(city);
//        }

//        foreach (var (continentName, countries) in states)
//        {
//            Console.WriteLine($"{continentName}:");
//            foreach (var (countryName, citiesInCountry) in countries)
//            {
//                Console.WriteLine($" {countryName} -> " +
//                    string.Join(", ", citiesInCountry));
//            }
//        }
//    }

//}


     //////////////////////////////////////////////////////////////////////// Second Variant ////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var state = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < rows; i++)
            {
                string[] token = Console.ReadLine().Split(' ');
                string continents = token[0];
                string country = token[1];
                string city = token[2];

                if (!state.ContainsKey(continents))
                {
                    state.Add(continents, new Dictionary<string, List<string>>());
                }
                if (!state[continents].ContainsKey(country))
                {
                    state[continents].Add(country, new List<string>());
                }

                state[continents][country].Add(city);


            }

            foreach (var continent in state)
            {
                Console.WriteLine($"{continent.Key}: ");
                var country = continent.Value;
                foreach (var countries in country)
                {
                    Console.WriteLine($" {countries.Key} -> " + string.Join(", ", countries.Value));
                }
            }
        }
    }
}