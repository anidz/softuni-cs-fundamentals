using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {


        const double TaxiStartPrice = 0.70;
        const double TaxiDaylyRate = 0.79;
        const double TaxiNightRate = 0.90;
        const double BussPrice = 0.09;
        const double TrainPrice = 0.06;
        const int BussMinDistance = 20;
        const int TrainMinDistance = 100;

        int km = int.Parse(Console.ReadLine());
        string time = Console.ReadLine().ToLower();

            if (km < 20)
            {
                if (time == "day")
                {
                    Console.WriteLine($"{(km * TaxiDaylyRate + TaxiStartPrice):f2}");
                }
                else if (time == "night")
                {
                    Console.WriteLine($"{(km * TaxiNightRate + TaxiStartPrice):f2}");
                }
            }
            if (km >= BussMinDistance && km < TrainMinDistance)
            {
                Console.WriteLine($"{(km * BussPrice):f2}");
            }
            if (km >= TrainMinDistance)
            {
                Console.WriteLine($"{(km * TrainPrice):f2}");
            }
        }
            }
        }
    

