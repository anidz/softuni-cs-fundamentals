using System;

namespace _10.ExperienceGaining
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantedExperience = int.Parse(Console.ReadLine());

            int amountOfBattle = int.Parse(Console.ReadLine());

            double totalExperience = 0;

            int numberOfBattle = 0;

            int momentNumber = 0;

            for (int i = 0; i < amountOfBattle; i++)
            {
                numberOfBattle++;


                double addExperience = double.Parse(Console.ReadLine());

                if (numberOfBattle % 3 == 0)
                {
                    addExperience += addExperience * 0.15;
                }
                else if (numberOfBattle % 5 == 0)
                {
                    addExperience -= addExperience * 0.10;
                }
                else if (numberOfBattle % 15 == 0)
                {
                    addExperience += addExperience * 0.05;
                }

                totalExperience += addExperience;
                if (totalExperience >= wantedExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {numberOfBattle} battles.");
                    return;
                }
            }

            Console.WriteLine($"Player was not able to collect the needed experience, {$"{(wantedExperience - totalExperience):f2}"} more needed.");
        }
    }
}
        
    

