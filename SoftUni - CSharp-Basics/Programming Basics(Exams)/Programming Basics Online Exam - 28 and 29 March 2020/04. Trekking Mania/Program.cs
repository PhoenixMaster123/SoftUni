using System;

namespace _04._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoplesGroup = int.Parse(Console.ReadLine());
            double allPeople = 0;
            double musulaPeople = 0;
            double monbanPeople = 0;
            double kilimanjaroPeople = 0;
            double k2People = 0;
            double everestPeople = 0;
            for (int i = 0; i < peoplesGroup; i++)
            {
                int countPeopleOnGroup = int.Parse(Console.ReadLine());
                allPeople += countPeopleOnGroup;
                if (countPeopleOnGroup <= 5)
                {
                    musulaPeople += countPeopleOnGroup;
                }
                else if (countPeopleOnGroup >= 6 && countPeopleOnGroup <= 12)
                {
                    monbanPeople += countPeopleOnGroup;
                }
                else if (countPeopleOnGroup >= 13 && countPeopleOnGroup <= 25)
                {
                    kilimanjaroPeople += countPeopleOnGroup;
                }
                else if (countPeopleOnGroup >= 26 && countPeopleOnGroup <= 40)
                {
                    k2People += countPeopleOnGroup;
                }
                else if (countPeopleOnGroup >= 41)
                {
                    everestPeople += countPeopleOnGroup;
                }
            }
            Console.WriteLine($"{musulaPeople / allPeople * 100:F2}%");
            Console.WriteLine($"{monbanPeople / allPeople * 100:F2}%");
            Console.WriteLine($"{kilimanjaroPeople / allPeople * 100:F2}%");
            Console.WriteLine($"{k2People / allPeople * 100:F2}%");
            Console.WriteLine($"{(everestPeople / allPeople) * 100:F2}%");
        }
    }
}
