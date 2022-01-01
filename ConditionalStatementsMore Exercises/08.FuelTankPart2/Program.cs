using System;

namespace _08.FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelAmount = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double gasolinePrice = 2.22;
            double gasPrice = 0.93;
            double dieselPrice = 2.33;

            double gasolinePriceWithClubCard = gasolinePrice - 0.18;
            double gasPriceWithClubCard = gasPrice - 0.08;
            double dieselPriceWithClubCard = dieselPrice - 0.12;

            double result = 0;

            if (fuelAmount > 25)
            {
                gasolinePrice *= 0.9;
                gasPrice *= 0.9;
                dieselPrice *= 0.9;

                gasolinePriceWithClubCard *= 0.9;
                gasPriceWithClubCard *= 0.9;
                dieselPriceWithClubCard *= 0.9;
            }
            else if (fuelAmount >= 20)
            {
                gasolinePrice *= 0.92;
                gasPrice *= 0.92;
                dieselPrice *= 0.92;

                gasolinePriceWithClubCard *= 0.92;
                gasPriceWithClubCard *= 0.92;
                dieselPriceWithClubCard *= 0.92;
            }

            if (clubCard == "Yes")
            {
                if (fuelType == "Gasoline")
                {
                    result = gasolinePriceWithClubCard * fuelAmount;
                }
                else if (fuelType == "Gas")
                {
                    result = gasPriceWithClubCard * fuelAmount;
                }
                else if (fuelType == "Diesel")
                {
                    result = dieselPriceWithClubCard * fuelAmount;
                }
            }
            else
            {
                if (fuelType == "Gasoline")
                {
                    result = gasolinePrice * fuelAmount;
                }
                else if (fuelType == "Gas")
                {
                    result = gasPrice * fuelAmount;
                }
                else if (fuelType == "Diesel")
                {
                    result = dieselPrice * fuelAmount;
                }
            }

            Console.WriteLine($"{result:f2} lv.");
        }
    }
    }

