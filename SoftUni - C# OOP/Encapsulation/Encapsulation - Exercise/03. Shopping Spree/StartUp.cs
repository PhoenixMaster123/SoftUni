using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    class StartUp
    {
        static void Main()
        {
            string[] namesSpree = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Person> humans = new List<Person>();
            for (int k = 0; k < namesSpree.Length; k += 2)
            {
                try
                {
                    Person person = new Person(namesSpree[k], int.Parse(namesSpree[k + 1]));
                    humans.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
            namesSpree = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Product> products = new List<Product>();
            for (int k = 0; k < namesSpree.Length; k += 2)
            {
                try
                {
                    Product product = new Product(namesSpree[k], int.Parse(namesSpree[k + 1]));
                    products.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
            string[] cmd = Console.ReadLine().Split(" ").ToArray();
            while (cmd[0]?.ToUpper() != "END")
            {
                string personName = cmd[0];
                string productName = cmd[1];

                Person currentPerson = humans.FirstOrDefault(p => p.Name == personName);
                Product currentProduct = products.FirstOrDefault(p => p.Name == productName);
                if (currentPerson != null && currentProduct != null)
                {
                    Console.WriteLine(currentPerson.CanAfford(currentProduct));
                }

                cmd = Console.ReadLine().Split(" ").ToArray();
            }

            humans.ForEach(p => Console.WriteLine(p));
        }
    }
}