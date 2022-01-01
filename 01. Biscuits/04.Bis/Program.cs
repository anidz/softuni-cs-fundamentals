using System;

namespace _04.Bis
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingFactoryProduction = int.Parse(Console.ReadLine());
            double totalBiscuits = 0;

            for (int i = 1; i < 31; i++)
            {
                if (i % 3 == 0)
                {
                    totalBiscuits += Math.Floor((biscuitsPerDayPerWorker * workers) * 0.75);
                }
                else
                {
                    totalBiscuits += biscuitsPerDayPerWorker * workers;
                }
            }
            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
            double percentage = 0;
            if (totalBiscuits > competingFactoryProduction)
            {
                percentage = ((totalBiscuits - competingFactoryProduction) / competingFactoryProduction) * 100;
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                percentage = ((Math.Abs(totalBiscuits - competingFactoryProduction)) / competingFactoryProduction) * 100;
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
 

        
    

