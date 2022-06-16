using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treatment = 0;
           int  untreatment = 0;
            for(int i=1;i<=period;i++)
            {              

                //sum += (patients - doctors);
                if (period % 3 == 0 && untreatment > treatment) 
                {
                    doctors++;
                    //sum += (patients - doctors);
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients > doctors)
                {
                    treatment += doctors;
                    untreatment += patients - doctors;
                   
                }
                else
                {
                    treatment += patients;
                }              
            }
            Console.WriteLine($"Treated patients: {treatment}.");
            Console.WriteLine($"Untreated patients: {untreatment}.");

        }
    }
}
