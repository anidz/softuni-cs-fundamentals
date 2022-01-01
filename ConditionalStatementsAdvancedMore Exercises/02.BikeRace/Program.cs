using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string typeRout = Console.ReadLine();

            double total = 0;
            if (typeRout == "trail")
            {
                total = (juniors * 5.5) + (seniors * 7) - (0.05 * ((juniors * 5.5) + (seniors * 7)));

            }
            else if (typeRout == "downhill")
            {
                total = (juniors * 12.25) + (seniors * 13.75) - (0.05 * ((juniors * 12.25) + (seniors * 13.75)));
            }
            else if (typeRout == "road")
            {
                total = (juniors * 20) + (seniors * 21.5) - (0.05 * ((juniors * 20) + (seniors * 21.5)));
            }
            else if (typeRout == "cross-country" && ((juniors + seniors) < 50))
            {
                total = ((juniors * 8) + (seniors * 9.5) - (0.05 * ((juniors * 8) + (seniors * 9.5))));
            }
            else if (typeRout == "cross-country" && ((juniors + seniors) >= 50))
            {
                total = ((juniors * 6) + (seniors * 7.125)) - (0.05 * ((juniors * 6) + (seniors * 7.125))); 
            }
            Console.WriteLine($"{total:f2}");

        }
    }
    }

