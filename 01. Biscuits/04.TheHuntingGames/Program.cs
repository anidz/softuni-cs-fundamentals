using System;

namespace _04.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysOAdventure = double.Parse(Console.ReadLine());
            double numberOfPlayers = double.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayOnePerson = double.Parse(Console.ReadLine());

            double totalWaterSupplies = waterPerDayOnePerson * numberOfPlayers * daysOAdventure;
            double totalFoodSupplies = foodPerDayOnePerson * numberOfPlayers * daysOAdventure;

            double leftoverFoodSupplies = 0;

            for (int i = 1; i <= daysOAdventure; i++)
            {
                double energyLostperDay = double.Parse(Console.ReadLine());

                groupEnergy -= energyLostperDay;
                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFoodSupplies:f2} food and {totalWaterSupplies:f2} water.");
                    return;
                }

                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    totalWaterSupplies -= totalWaterSupplies * 0.30; ////// possible mistake with math !!!!!
                }

                if (i % 3 == 0)
                {
                    groupEnergy *= 1.10;
                    totalFoodSupplies -= totalFoodSupplies / numberOfPlayers;
                }
            }

            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
        }
    }
}
        
    

