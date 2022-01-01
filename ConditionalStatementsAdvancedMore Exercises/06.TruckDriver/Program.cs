using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double money = 0;
            {
                if (season == "Summer")
                {

                    if (kilometers <= 5000)
                    {
                        money = (kilometers * 0.90);
                    }

                    else if (5000 < kilometers && kilometers <= 10000)
                    {
                        money = (kilometers * 1.10);
                    }
                    else
                    {
                        money = (kilometers * 1.45);
                    }
                }
                if (season == "Winter")
                {

                    if (kilometers <= 5000)
                    {
                        money = (kilometers * 1.05);
                    }

                    else if (5000 < kilometers && kilometers <= 10000)
                    {
                        money = (kilometers * 1.25);
                    }
                    else
                    {
                        money = (kilometers * 1.45);
                    }
                }

                if (season == "Spring" || season == "Autumn")
                {

                    if (kilometers <= 5000)
                    {
                        money = (kilometers * 0.75);
                    }

                    else if (5000 < kilometers && kilometers <= 10000)
                    {
                        money = (kilometers * 0.95);
                    }
                    else
                    {
                        money = (kilometers * 1.45);
                    }
                }
            }
            money = (money * 4);
            money *= 0.9;

            Console.WriteLine($"{money:F2}");
        }
    }
    }

