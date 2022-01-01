using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int daysAtWork = 365 - daysOff;
            int playMins = (daysOff * 127) + (daysAtWork * 63);

            if (playMins > 30000)
            {
                int difference = playMins - 30000;
                int hours = 0;
                int minutes = 0;
                if (difference > 59)
                {
                    hours = difference / 60;
                    minutes = difference - (hours * 60);
                }

                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (playMins <= 30000)
            {
                int difference = 30000 - playMins;
                int hours = 0;
                int minutes = 0;
                if (difference > 59)
                {
                    hours = difference / 60;
                    minutes = difference - (hours * 60);

                }

                {
                    Console.WriteLine($"Tom sleeps well");
                    Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
                }
            }
        }
    }
}

