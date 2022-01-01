using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersDays = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double foodPerDayDogKg = double.Parse(Console.ReadLine());
            double foodPerDayCatKg = double.Parse(Console.ReadLine());
            double foodPerDayTurtleG = double.Parse(Console.ReadLine());

            double neededFoodDog = numbersDays * foodPerDayDogKg;
            double neededFoodCat = numbersDays * foodPerDayCatKg;
            double neededFoodTurtle = numbersDays * foodPerDayTurtleG / 1000;
            double totalFood = neededFoodDog + neededFoodCat + neededFoodTurtle;

            if (totalFood <= foodKg)
            {
                double d = foodKg - totalFood;
                Console.WriteLine($"{Math.Floor(d)} kilos of food left.");
                    
            }
            else
            {
                double f = totalFood - foodKg;
                Console.WriteLine($"{Math.Ceiling(f)} more kilos of food are needed.");
            }


        }
    }
}
