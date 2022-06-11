using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Facebook = 150;
            const int Instagram = 100;
            const int Reddit = 50;

            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for(int i=0;i<=openedTabs;i++)
            {
                if(salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }

                string browserTaps = Console.ReadLine();
                if (browserTaps == "Facebook")
                {
                    salary -= Facebook;
                }
                else if (browserTaps == "Instagram")
                {
                    salary -= Instagram;
                }
                else if (browserTaps == "Reddit")
                {
                    salary -= Reddit;
                }               
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }


        }
    }
}
