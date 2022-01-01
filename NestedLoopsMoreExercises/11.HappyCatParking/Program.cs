using System;

namespace _11.HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumToPayAfterParking = default(double);
            double currentSum = default(double);

            for (int daysCount = 1; daysCount <= days; daysCount++)
            {
                for (int hoursCount = 1; hoursCount <= hours; hoursCount++)
                {
                    if (daysCount % 2 == 0 && hoursCount % 2 != 0)
                    {
                        currentSum += 2.50;
                        sumToPayAfterParking += 2.50;
                    }
                    else if (daysCount % 2 != 0 && hoursCount % 2 == 0)
                    {
                        currentSum += 1.25;
                        sumToPayAfterParking += 1.25;
                    }
                    else
                    {
                        currentSum += 1;
                        sumToPayAfterParking += 1;
                    }
                }
                Console.WriteLine($"Day: {daysCount} - {currentSum:F2} leva");
                currentSum = 0;
            }
            Console.WriteLine($"Total: {sumToPayAfterParking:F2} leva");
        }
    }
    }

