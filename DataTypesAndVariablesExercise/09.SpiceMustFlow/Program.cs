using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MINIMUM_SPICES_TO_GATHER = 100;
            const int CONCUMED_BY_WORKERS = 26;
            const int DEYLY_DECREES = 10;
            int countOfSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCount = 0;

            while(countOfSpices >= MINIMUM_SPICES_TO_GATHER)
            {
                totalConsumed += countOfSpices - CONCUMED_BY_WORKERS;
                countOfSpices -= DEYLY_DECREES;
                daysCount++;
                if(countOfSpices < MINIMUM_SPICES_TO_GATHER)
                {
                    totalConsumed -= CONCUMED_BY_WORKERS;
                }
            }
            Console.WriteLine(daysCount);
            Console.WriteLine(totalConsumed);
        }
    }
}
