using System;
using System.Collections.Generic;

namespace _P03.Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            int points = 0;
            List<BaseHero> heroes = new List<BaseHero>();

            while (count > heroes.Count)
            {
                string name = Console.ReadLine();
                string typeOfHero = Console.ReadLine();

                switch (typeOfHero)
                {
                    case "Druid":
                        BaseHero heroDruid = new Druid(name);
                        heroes.Add(heroDruid);
                        break;
                    case "Paladin":
                        BaseHero heroPaladin = new Paladin(name);
                        heroes.Add(heroPaladin);
                        break;
                    case "Rogue":
                        BaseHero heroRogue = new Rogue(name);
                        heroes.Add(heroRogue);
                        break;
                    case "Warrior":
                        BaseHero heroWarrior = new Warrior(name);
                        heroes.Add(heroWarrior);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
            }

            foreach (var hero in heroes)
            {
                points += hero.Power;
                Console.WriteLine(hero.CastAbility());
            }

            int pointsFromBoss = int.Parse(Console.ReadLine());

            if (points >= pointsFromBoss)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
