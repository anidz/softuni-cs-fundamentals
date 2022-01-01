using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double butget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string clas = "";
            string auto = "";
            double spend = 0.0;
            if (butget <= 100)
            {
                clas = "Economy class";
                if (season == "summer")
                {
                    auto = "Cabrio";
                    spend = 0.35 * butget;
                }
                else if (season == "winter")
                {
                    auto = "Jeep";
                    spend = 0.65 * butget;
                }
            }
            else if (butget > 100 && butget <= 500)
            {
                clas = "Compact class";
                if (clas == "summer")
                {
                    auto = "Cabrio";
                    spend = 0.45 * butget;
                }
                else if (season == "winter")
                {
                    auto = "Jeep";
                    spend = 0.8 * butget;
                }
            }
            else
            {
                clas = "Luxury class";
                auto = "Jeep";
                spend = 0.9 * butget;
            }
            Console.WriteLine($"{clas}");
            Console.WriteLine($"{auto} - {spend:f2}");
        }
    }
        }
    

