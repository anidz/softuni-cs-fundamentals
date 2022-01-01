using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishers = int.Parse(Console.ReadLine());

            double rent = 0;

            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }

            
            if (countFishers <= 6)
            {
                rent = rent - 0.10 * rent; 
                
            }
            else if (countFishers >= 7 && countFishers <= 11)
            {
                rent = rent - 0.15 * rent; 
            }
            else if (countFishers >= 12)
            {
                rent = rent - 0.25 * rent; 
            }


            if (countFishers % 2 == 0 && season != "Autumn")
            {
                rent = rent - 0.05 * rent; 
            }

            if (budget >= rent)
            {
                double leftMoney = budget - rent;
                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
            }
            else 
            {
                double needMoney = rent - budget;
                Console.WriteLine($"Not enough money! You need {needMoney:F2} leva.");
            }
        }
    }
}
